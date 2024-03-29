﻿using System;
using System.Collections.Generic;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Windows.Forms;

namespace Body_Factory_Manager
{
    public partial class SeccionMensualidades : UserControl
    {
        SQL sql;
        string consulta;
        FiltroBusqeda filtro;
        Comunicacion comunicacion = new Comunicacion();

        public string idCliente;


        public SeccionMensualidades(FiltroBusqeda filtro = null)
        {
            sql = new SQL(Properties.Settings.Default.ConnectionString);
            this.filtro = filtro;
            if (filtro == null)
            {
                this.filtro = new FiltroBusqeda(TipoFiltro.Nada);
            }



            //DialogResult = DialogResult.Cancel;

            
            

            InitializeComponent();

            List<ListadoButtonDatos> buttonDatos = new List<ListadoButtonDatos>();
            buttonDatos.Add(new ListadoButtonDatos(true, "Ver en lista", Body_Factory_Manager.Properties.Resources.calendario, this.VerEnlista, 7));
            buttonDatos.Add(new ListadoButtonDatos(true, "Editar", Body_Factory_Manager.Properties.Resources.editar, this.Editar));
            buttonDatos.Add(new ListadoButtonDatos(true, "Pagar", Body_Factory_Manager.Properties.Resources.signo_de_dolar, this.PagarCuota));
            buttonDatos.Add(new ListadoButtonDatos(true, "Pagos", Body_Factory_Manager.Properties.Resources.factura, this.VerPagos, 10));
            buttonDatos.Add(new ListadoButtonDatos(true, "Borrar", Body_Factory_Manager.Properties.Resources.eliminar, this.Eliminar));


            List<FiltroBusqeda> filtros = new List<FiltroBusqeda>();
            filtros.Add(new FiltroBusqeda(TipoFiltro.String, "Nombre del cliente", "CONCAT(nombre, ' ', apellido)"));
            filtros.Add(new FiltroBusqeda(TipoFiltro.String, "Cédula del cliente", "cedula"));
            filtros.Add(new FiltroBusqeda(TipoFiltro.FechaMes, "Mes y año", "CONCAT('01/', mes, '/', anio)"));
            filtros.Add(new FiltroBusqeda(TipoFiltro.NumeroRango, "Rango de valores($)", "valor"));
            filtros.Add(new FiltroBusqeda(TipoFiltro.NumeroRango, "Rango de deudas($)", "((valor * (1 - descuento / 100)) - pagado)"));
            filtros.Add(new FiltroBusqeda(TipoFiltro.FechaRango, "Fecha de vencimiento", "vencimiento"));

            listado = new Listado(new List<string> { "idCliente", "mesOculto", "Año" }, buttonDatos, 1, filtros, Filtrar, 1);

            this.pestaniasTCL.TabPages[1].Controls.Add(listado);
            listado.Location = new Point(0, 0);
            listado.Dock = DockStyle.Fill;

            diasNUD.Value = 6;

           

            anioNUD.Value = DateTime.Now.Year;

            ActualizarConsulta();

            tablaDGV.Rows[DateTime.Now.Month - 1].Selected = true;

            

            


        }

        public SeccionMensualidades(string idCliente) : this(new FiltroBusqeda(TipoFiltro.Nada))
        {

            ActualizarCliente(idCliente);
            ActualizarDisponibilidadBotones();
            ActualizarConsulta();

        }

        private void ActualizarCliente(string idCliente)
        {
            this.idCliente = idCliente;
            if (idCliente == null) return;
                estadoPNL.BackColor = (bool)sql.Obtener("SELECT esActivo FROM Clientes WHERE id=" + idCliente).Rows[0]["esActivo"] ? estadoPNL.BackColor = Color.Green : Color.Red;

            nombreTBX.Text = sql.Obtener("SELECT CONCAT(nombre, ' ', apellido) as nombre FROM Clientes WHERE id=" + idCliente).Rows[0]["nombre"].ToString();

        }

        private void Eliminar(Dictionary<string, object> datos)
        {
            if (MessageBox.Show("Confirmar borrado", "¿Esta seguro que quiere eliminar los datos de la mensualidad?", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.No) return;
            sql.Modificar("DELETE FROM Mensualidades WHERE idCliente= '" + datos["idCliente"] + "' AND mes='" + datos["mesOculto"] + "' AND anio='" + datos["Año"] + "'");
            CargarListaMensualidades();
        }

        private void CargarListaMensualidades()
        {
            

            tablaDGV.Rows.Clear();
            for (int i = 0; i < 12; i++)
            {
                try
                {
                    tablaDGV.Rows.Add();
                    tablaDGV.Rows[i].Cells[0].Value = DateTime.ParseExact("01/" + (i + 1) + "/2001", "dd/M/yyyy", CultureInfo.InvariantCulture).ToString("MMMM");
                    DataTable datos = sql.Obtener("SELECT pagado, valor, descuento, ISNULL(CONVERT(VARCHAR(MAX),vencimiento,103),'Sin vencimiento') as vencimiento , CONVERT(DECIMAL(6, 2), valor * (1 - descuento / 100)) as total, ((valor * (1 - descuento / 100)) - pagado) as deuda, ISNULL(CONVERT(VARCHAR(10),ultimoPago,103),'Sin pagos') as ultimoPago " +
    "FROM(SELECT Mensualidades.idCliente, Mensualidades.mes, Mensualidades.anio, (ISNULL(SUM(monto), 0)) AS pagado, MAX(Pagos.fecha) as ultimoPago " +
    "FROM Mensualidades LEFT JOIN Pagos ON Pagos.idCliente = Mensualidades.idCliente AND Pagos.mesMensualidad = Mensualidades.mes AND Pagos.anioMensualidad = Mensualidades.anio " +
    "WHERE Mensualidades.idCliente = '" + idCliente + "' AND Mensualidades.mes = " + (i + 1) + " AND Mensualidades.anio = " + anioNUD.Value +
    " GROUP BY Mensualidades.idCliente, Mensualidades.mes, Mensualidades.anio) AS PagosMensualidades " +
    "INNER JOIN Mensualidades ON PagosMensualidades.idCliente = Mensualidades.idCliente AND PagosMensualidades.mes = Mensualidades.mes AND PagosMensualidades.anio = Mensualidades.anio");
                    if (datos == null || datos.Rows.Count == 0)
                    {
                        tablaDGV.Rows[i].Tag = "Vacío";
                        continue;
                    }
                    tablaDGV.Rows[i].Cells[1].Value = datos.Rows[0]["valor"];
                    tablaDGV.Rows[i].Cells[2].Value = datos.Rows[0]["descuento"];
                    tablaDGV.Rows[i].Cells[3].Value = datos.Rows[0]["total"];
                    tablaDGV.Rows[i].Cells[4].Value = datos.Rows[0]["deuda"];
                    tablaDGV.Rows[i].Cells[5].Value = datos.Rows[0]["vencimiento"];
                    tablaDGV.Rows[i].Cells[6].Value = datos.Rows[0]["ultimoPago"];
                }
                catch (Exception e)
                {
                    MessageBox.Show("Error al cargar las cuotas del cliente, razón: \n " + e.Message);
                }
                


            }

            if (anioNUD.Value == DateTime.Now.Year) tablaDGV.Rows[DateTime.Now.Month - 1].Selected = true;


        }

        private void Editar(Dictionary<string, object> datos)
        {
            using (DatosMensualidad datosMensualidad = new DatosMensualidad(TipoPagoMensualidad.EditarMensualidad, datos["idCliente"].ToString(), datos["mesOculto"].ToString(), datos["Año"].ToString()))
            {
                if (datosMensualidad.ShowDialog() == DialogResult.OK) ActualizarConsulta();

            }

        }

        private void VerEnlista(Dictionary<string, object> datos)
        {
            pestaniasTCL.SelectedIndex = 0;
            ActualizarCliente(datos["idCliente"].ToString());
            anioNUD.Value = int.Parse(datos["Año"].ToString());
            ActualizarConsulta();
            tablaDGV.Rows[int.Parse(datos["mesOculto"].ToString()) - 1].Selected = true;

            

        }

        


        private void Filtrar(FiltroBusqeda filtro)
        {
            this.filtro = filtro;
            ActualizarConsulta();
        }


        private void PagarCuota(Dictionary<string, object> datos)
        {
            using (DatosMensualidad nuevaVentana = new DatosMensualidad(TipoPagoMensualidad.NuevoPago, datos["idCliente"].ToString(), datos["mesOculto"].ToString(), datos["Año"].ToString()))
            {
                nuevaVentana.ShowDialog();
                if (nuevaVentana.DialogResult == DialogResult.OK) ActualizarConsulta();
            }
        }


        private void ActualizarConsulta()
        {
            consulta = "SET Language 'Spanish'; " +
                "SELECT idCliente, DATENAME(month, CONCAT('2022-',mes,'-01')) as Mes, mes as mesOculto, anio as 'Año', cedula as 'Cédula', CONCAT(nombre, ' ', apellido) as 'Nombre completo', valor as 'Cuota($)', descuento as 'Descuento(%)', (CONVERT(DECIMAL(6,2),valor * (1 - descuento / 100))) as 'Total($)', ((valor * (1 - descuento / 100)) - pagado) as 'Deuda($)', ISNULL(CONVERT(VARCHAR(MAX),vencimiento,103),'Sin vencimiento') as Vencimiento " +
                "FROM(SELECT Mensualidades.idCliente, pagado, valor, descuento, Mensualidades.mes, Mensualidades.anio, vencimiento " +
                "FROM(SELECT Mensualidades.idCliente, Mensualidades.mes, Mensualidades.anio, (ISNULL(SUM(monto), 0)) AS pagado " +
                "FROM Mensualidades " +
                "LEFT JOIN Pagos ON Pagos.idCliente = Mensualidades.idCliente AND Pagos.mesMensualidad = Mensualidades.mes AND Pagos.anioMensualidad = Mensualidades.anio " +
                "GROUP BY Mensualidades.idCliente, Mensualidades.mes, Mensualidades.anio) AS PagosMensualidades " +
                "INNER JOIN Mensualidades ON PagosMensualidades.idCliente = Mensualidades.idCliente AND PagosMensualidades.mes = Mensualidades.mes AND PagosMensualidades.anio = Mensualidades.anio) as FullMensualidades " +
                "INNER JOIN Clientes on FullMensualidades.idCliente = Clientes.id WHERE ";
            if (!pagasCBX.Checked)
            {
                consulta += "((valor * (1 - descuento / 100)) - pagado) > 0 AND ";

            }


            consulta += filtro.ObtenerWhereConsulta();

            if(idCliente!=null) 
            {
                try
                {
                    DataTable ultimoIngreso = sql.Obtener("SELECT MAX(fecha) as fecha FROM IngresosClientes WHERE idCliente=" + idCliente + "GROUP BY idCliente");
                    if (ultimoIngreso.Rows.Count != 0) ultimoIngresoLBL.Text = "Último ingreso: " + ((DateTime)ultimoIngreso.Rows[0]["fecha"]).ToString("dd/MM/yyyy");
                    else ultimoIngresoLBL.Text = "Último ingreso: Sin registrar";
                }
                catch
                {

                }
                finally
                {
                    sql.CerrarConexion();
                }
            }

            
            

            listado.datos = sql.Obtener(consulta);
            listado.Recargar(new List<string>{"mesOculto", "idCliente"}, (int)diasNUD.Value);
            CargarListaMensualidades();
            ActualizarDisponibilidadBotones();
        }


        private void diasNUD_ValueChanged_1(object sender, EventArgs e)
        {
            ActualizarConsulta();
        }

        private void pagasCBX_CheckedChanged(object sender, EventArgs e)
        {
            ActualizarConsulta();
        }

        private void SeccionMensualidades_Load(object sender, EventArgs e)
        {

        }

        private void buscarClienteBTN_Click(object sender, EventArgs e)
        {
            FiltroBusqeda filtro = new FiltroBusqeda(TipoFiltro.Nada);
            using (SelectorClientes listado = new SelectorClientes(filtro))
            {
                listado.ShowDialog();
                if (listado.DialogResult == DialogResult.OK)
                {
                   ActualizarCliente(listado.id);
                    
                    ActualizarConsulta();

                    
                }
            }
        }

        


        private void anotarBTN_Click(object sender, EventArgs e)
        {
            if (nombreTBX.Text == "No encontrado" || tablaDGV.SelectedCells.Count == 0) return;
            using (DatosMensualidad datosMensualidad = new DatosMensualidad(TipoPagoMensualidad.EditarMensualidad, idCliente, (tablaDGV.SelectedCells[0].RowIndex + 1).ToString(), anioNUD.Value.ToString()))
            {
                if (datosMensualidad.ShowDialog() == DialogResult.OK) ActualizarConsulta();

            }
        }

        private void pagarBTN_Click(object sender, EventArgs e)
        {
            if (nombreTBX.Text == "No encontrado" || tablaDGV.SelectedCells.Count == 0) return;
            using (DatosMensualidad datosMensualidad = new DatosMensualidad(TipoPagoMensualidad.NuevoPago, idCliente, (tablaDGV.SelectedCells[0].RowIndex + 1).ToString(), anioNUD.Value.ToString()))
            {
                if (datosMensualidad.ShowDialog() == DialogResult.OK) ActualizarConsulta();

            }
        }

        private void borrarBTN_Click(object sender, EventArgs e)
        {
            if (nombreTBX.Text == "No encontrado" || tablaDGV.SelectedCells.Count == 0 || tablaDGV.SelectedRows[0].Tag != null) return;
            if (MessageBox.Show("Confirmar borrado", "¿Esta seguro que quiere eliminar la o las mensualidades?", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.No) return;
            string c = "DELETE FROM Mensualidades WHERE idCliente = " + idCliente + "  AND mes IN ('0'" ;
            foreach (DataGridViewRow row in tablaDGV.SelectedRows)
            {
                c += ",'" + (row.Index + 1) + "'";
                
            }
            c += ") AND anio= '" + anioNUD.Value + "'";
            sql.Modificar(c);
            ActualizarConsulta();
        }

        private void verPagosBTN_Click(object sender, EventArgs e)
        {
            if (nombreTBX.Text == "No encontrado" || tablaDGV.SelectedCells.Count == 0) return;
            FiltroBusqeda filtro = new FiltroBusqeda(TipoFiltro.Numero, "", "idCliente = " + idCliente + " AND mesMensualidad= '" + (tablaDGV.SelectedCells[0].RowIndex + 1).ToString() + "' AND anioMensualidad = '" + anioNUD.Value + "' AND 1");
            filtro.valor1 = "1";
            using (Form form = new Form())
            {
                SeccionPagos seccionPagos = new SeccionPagos(filtro, false);
                form.Controls.Add(seccionPagos);
                seccionPagos.Dock = DockStyle.Fill;
                form.Size = new Size(849, 400);
                form.StartPosition = FormStartPosition.CenterScreen;
                form.ShowDialog();
            }
            ActualizarConsulta();
        }

        private void VerPagos(Dictionary<string, object> datos)
        {
            FiltroBusqeda filtro = new FiltroBusqeda(TipoFiltro.Numero, "", "idCliente = " + datos["idCliente"] + " AND mesMensualidad= '" + datos["mesOculto"] + "' AND anioMensualidad = '" + datos["Año"] + "' AND 1");
            filtro.valor1 = "1";
            using (Form form = new Form())
            {
                SeccionPagos seccionPagos = new SeccionPagos(filtro, false);
                form.Controls.Add(seccionPagos);
                seccionPagos.Dock = DockStyle.Fill;
                form.Size = new Size(849, 400);
                form.StartPosition = FormStartPosition.CenterScreen;
                form.ShowDialog();
            }
        }

        private void anioNUD_ValueChanged(object sender, EventArgs e)
        {
            ActualizarConsulta();
            
        }

        private void sigMesBTN_Click(object sender, EventArgs e)
        {
            anioNUD.Value++;
        }

        private void antMesBTN_Click(object sender, EventArgs e)
        {
            anioNUD.Value--;
        }

        private void tablaDGV_SelectionChanged(object sender, EventArgs e)
        {
            ActualizarDisponibilidadBotones();
        }

        private void ActualizarDisponibilidadBotones()
        {
            int i = 0;
            foreach(Control c in opcionesPNL.Controls)
            {
                c.Enabled =  nombreTBX.Text != "No encontrado" && ((tablaDGV.SelectedRows.Count != 0 && tablaDGV.SelectedRows[0].Tag == null) || (tablaDGV.SelectedRows.Count != 0 && tablaDGV.SelectedRows[0].Tag != null && i == 2));
                i++;
            }
        }

        private void tablaDGV_RowPostPaint(object sender, DataGridViewRowPostPaintEventArgs e)
        {
            
            if(tablaDGV.Rows[e.RowIndex].Cells.GetCellValueFromColumnHeader("Vencimiento") == null) return;

            DateTime fecha = tablaDGV.Rows[e.RowIndex].Cells.GetCellValueFromColumnHeader("Vencimiento").ToString() != "Sin vencimiento" ?
                DateTime.ParseExact(tablaDGV.Rows[e.RowIndex].Cells.GetCellValueFromColumnHeader("Vencimiento").ToString(), "dd/MM/yyyy", CultureInfo.InvariantCulture) : DateTime.Now.AddDays(-1);

            if (double.Parse(tablaDGV.Rows[e.RowIndex].Cells.GetCellValueFromColumnHeader("Deuda($)").ToString()) > 0)
            {
                if (DateTime.Now > fecha)
                {
                    tablaDGV.Rows[e.RowIndex].DefaultCellStyle.BackColor = Color.Red;
                    tablaDGV.Rows[e.RowIndex].DefaultCellStyle.SelectionBackColor = Color.Red;
                    tablaDGV.Rows[e.RowIndex].DefaultCellStyle.SelectionForeColor = Color.White;

                    return;
                }
                if (fecha.Subtract(DateTime.Now).Days <= diasNUD.Value)
                {
                    tablaDGV.Rows[e.RowIndex].DefaultCellStyle.BackColor = Color.Yellow;
                    tablaDGV.Rows[e.RowIndex].DefaultCellStyle.SelectionBackColor = Color.Yellow;
                    tablaDGV.Rows[e.RowIndex].DefaultCellStyle.SelectionForeColor = Color.White;
                }
            }
            else
            {
                tablaDGV.Rows[e.RowIndex].DefaultCellStyle.BackColor = Color.Green;
                tablaDGV.Rows[e.RowIndex].DefaultCellStyle.SelectionBackColor = Color.Green;
                tablaDGV.Rows[e.RowIndex].DefaultCellStyle.SelectionForeColor = Color.White;
            }
        }

        private void estadoPanel_Click(object sender, EventArgs e)
        {
            CambiarEstado();
        }

        private void estadoLBL_Click(object sender, EventArgs e)
        {
            CambiarEstado();
        }
        private void CambiarEstado()
        {
            if (nombreTBX.Text == "No encontrado") return;
            try
            {
                if (estadoPNL.BackColor == Color.Red && MessageBox.Show("¿Desea dar de alta el servicio del cliente? (Volverá a generar cuota automáticamente cuando se pague la última activa y se registrará la fecha de hoy como reingreso)", "Alta de servicio", MessageBoxButtons.YesNo, MessageBoxIcon.Asterisk) == DialogResult.Yes)
                {
                    sql.Modificar("UPDATE Clientes SET esActivo = 1 WHERE id=" + idCliente + "" +
                        " INSERT INTO IngresosClientes (idCliente, fecha, comentario) VALUES(" + idCliente+",GETDATE(), 'Reingreso')");
                    
                    estadoPNL.BackColor = Color.Green;
                    estadoLBL.Text = "Activo";
                    ActualizarConsulta();
                }
                else if(estadoPNL.BackColor == Color.Green && MessageBox.Show("¿Desea dar de baja el servicio del cliente? (No volverá a generar cuota automáticamente cuando se pague la última activa)", "Baja de servicio", MessageBoxButtons.YesNo, MessageBoxIcon.Asterisk) == DialogResult.Yes)
                {
                    sql.Modificar("UPDATE Clientes SET esActivo = 0 WHERE id=" + idCliente + "");
                    estadoPNL.BackColor = Color.Red;
                    estadoLBL.Text = "Pasivo";
                }
                
            }
            catch (Exception e)
            {
                MessageBox.Show("Error de base datos, razón:\n" + e.Message, "Eror de base de datos", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                sql.CerrarConexion();
            }
            
        }

        private void verIngresosLBL_Click(object sender, EventArgs e)
        {
            if (idCliente == null) return;
            using (SelectorIngresosClientes nuevaVentana = new SelectorIngresosClientes(idCliente))
            {
                nuevaVentana.ShowDialog();
            }
        }
    }
}
