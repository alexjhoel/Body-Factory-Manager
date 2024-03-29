﻿using System;
using System.Collections.Generic;
using System.Data;
using System.Windows.Forms;

namespace Body_Factory_Manager
{
    public partial class SeccionClientes : UserControl
    {
        SQL sql = new SQL(Properties.Settings.Default.ConnectionString);
        string consulta;
        FiltroBusqeda filtro;
        Comunicacion comunicacion = new Comunicacion();
        public string cedula;
        public string propiedadOrden;
        public SortOrder orden;
        Action<string> irMensualidades;

        public SeccionClientes(Action<string> irMensualidades, bool selector = false, FiltroBusqeda filtro = null, Action<string> seleccionar = null)
        {

            this.filtro = filtro;
            if (filtro == null)
            {
                this.filtro = new FiltroBusqeda(TipoFiltro.Nada);
            }

            InitializeComponent();


            List<ListadoButtonDatos> buttonDatos = new List<ListadoButtonDatos>();
            if (selector)
            {
                buttonDatos.Add(new ListadoButtonDatos(true, "Listo", Body_Factory_Manager.Properties.Resources.check, delegate (Dictionary<string, object> datos) { seleccionar(datos["Cédula"].ToString()); }));
                buttonDatos.Add(new ListadoButtonDatos(true, "Ver", Body_Factory_Manager.Properties.Resources.ver, this.Ver));
            }
            else
            {
                buttonDatos.Add(new ListadoButtonDatos(false, "Nuevo", Body_Factory_Manager.Properties.Resources.person_add_FILL0_wght400_GRAD0_opsz48, this.Agregar));
                buttonDatos.Add(new ListadoButtonDatos(true, "Editar", Body_Factory_Manager.Properties.Resources.editar, this.Editar));
                buttonDatos.Add(new ListadoButtonDatos(true, "Chatear", Body_Factory_Manager.Properties.Resources.chat, this.Chatear));
                buttonDatos.Add(new ListadoButtonDatos(true, "Correo", Body_Factory_Manager.Properties.Resources.email, this.Email));
                buttonDatos.Add(new ListadoButtonDatos(true, "Servicio", Body_Factory_Manager.Properties.Resources.AltoBajo, this.BajaAlta, 11));
                buttonDatos.Add(new ListadoButtonDatos(true, "Borrar", Body_Factory_Manager.Properties.Resources.eliminar, this.Borrar));
            }
            List<FiltroBusqeda> filtros = new List<FiltroBusqeda>();

            filtros.Add(new FiltroBusqeda(TipoFiltro.String, "Nombre", "nombre"));
            filtros.Add(new FiltroBusqeda(TipoFiltro.String, "Apellido", "apellido"));
            filtros.Add(new FiltroBusqeda(TipoFiltro.String, "Cédula", "cedula"));
            filtros.Add(new FiltroBusqeda(TipoFiltro.String, "Teléfono", "telefono"));
            filtros.Add(new FiltroBusqeda(TipoFiltro.FechaRango, "Fecha de Ingreso", "fechaIngreso"));

            listado = new Listado(new List<string> { "Cédula" }, buttonDatos, 1, filtros, Filtrar, 1); ;

            listado.Dock = DockStyle.Fill;
            this.irMensualidades = irMensualidades;
            this.Controls.Add(listado);
            ActualizarConsulta();
        }

        private void Borrar(Dictionary<string, object> datos)
        {
            if (string.IsNullOrEmpty(datos["Cédula"].ToString()))
            {
                MessageBox.Show("Esta acción requiere seleccionar un cliente", "Ningún cliente seleccionado", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            try
            {
                if (MessageBox.Show("Confirmar borrado", "¿Esta seguro que quiere eliminar el cliente?", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.No) return;
                sql.Modificar("DELETE FROM Clientes WHERE cedula= " + datos["Cédula"].ToString());
                CargarListaClientes();
            }
            catch (Exception e)
            {
                MessageBox.Show("Ocurrió un error, razón: " + e.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void BajaAlta(Dictionary<string, object> datos)
        {
            if (string.IsNullOrEmpty(datos["Cédula"].ToString()))
            {
                MessageBox.Show("Esta acción requiere seleccionar un cliente", "Ningún cliente seleccionado", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            try
            {
                if((bool)sql.Obtener("SELECT * FROM Clientes WHERE cedula='" + datos["Cédula"].ToString() + "'").Rows[0]["esActivo"])
                {
                    if(MessageBox.Show("¿Desea dar de baja el servicio de este cliente? El cliente no generará cuota automáticamente","Dar de baja",MessageBoxButtons.YesNo, MessageBoxIcon.Information) == DialogResult.Yes)
                    {
                        sql.Modificar("UPDATE Clientes SET esActivo=0 WHERE cedula = " + datos["Cédula"].ToString());
                    }
                }
                else {
                    if (MessageBox.Show("¿Desea dar de alta el servicio de este cliente? El cliente volverá a generar cuota automáticamente", "Dar de alta", MessageBoxButtons.YesNo, MessageBoxIcon.Information) == DialogResult.Yes)
                    {
                        sql.Modificar("UPDATE Clientes SET esActivo=1 WHERE cedula = '" + datos["Cédula"].ToString() + "';");
                    }
                }
                //if (MessageBox.Show("Confirmar borrado", "¿Esta seguro que quiere eliminar el cliente?", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.No) return;
                //sql.Modificar("UPDATE Clientes SET esOculto = 1, esActivo = 0 WHERE cedula= " + cedula);
                CargarListaClientes();
            }
            catch (Exception e){
                MessageBox.Show("Ocurrió un error, razón: " + e.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            

           
        }

        private void CargarListaClientes()
        {
            listado.datos = sql.Obtener(consulta);
            listado.Recargar();
        }

        private void Ver(Dictionary<string, object> datos)
        {
            using (DatosCliente nuevaVentana = new DatosCliente(datos["Cédula"].ToString(), false))
            {
                nuevaVentana.ShowDialog();
            }
        }

        private void Editar(Dictionary<string, object> datos)
        {
            using (DatosCliente nuevaVentana = new DatosCliente(datos["Cédula"].ToString()))
            {
                nuevaVentana.ShowDialog();
            }
            CargarListaClientes();
        }


        private void Filtrar(FiltroBusqeda filtro)
        {
            this.filtro = filtro;
            ActualizarConsulta();
        }
        private void ActualizarConsulta()
        {
            consulta = "SELECT nombre as Nombre, apellido as Apellido, cedula as 'Cédula', telefono as 'Teléfono', correo as 'Correo electrónico', fechaIngreso as 'Fecha de ingreso', IIF(esActivo=1, 'Activo', 'Pasivo') as 'Estado de servicio'  FROM Clientes ";
           
            consulta += " WHERE esOculto = 0 AND " + filtro.ObtenerWhereConsulta();
            CargarListaClientes();
        }



        private void Agregar(Dictionary<string, object> datos)
        {
            using (DatosCliente nuevaVentana = new DatosCliente(null, false))
            {
                nuevaVentana.ShowDialog();

                if(nuevaVentana.DialogResult == DialogResult.Yes)
                {
                    
                    irMensualidades(nuevaVentana.cedula);
                }
            }

            ActualizarConsulta();
        }

        private void Chatear(Dictionary<string, object> datos)
        {
            
            try
            {
                string telefono = sql.Obtener("SELECT * FROM Clientes WHERE cedula='" + datos["Cédula"].ToString() + "'").Rows[0]["telefono"].ToString();
                if (String.IsNullOrEmpty(telefono.Trim()))
                {
                    MessageBox.Show("El cliente no tiene un número registrado", "No se pudo iniciar el chat", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                comunicacion.Chatear(telefono);
                MessageBox.Show("Ventana abierta");
            }
            catch
            {
                MessageBox.Show("Ocurrió un error al abrir el navegador");
            }
            finally
            {
                sql.CerrarConexion();
            }
        }

        private void Email(Dictionary<string, object> datos)
        {

            try
            {
                string email = sql.Obtener("SELECT * FROM Clientes WHERE cedula='" + datos["Cédula"].ToString() + "'").Rows[0]["correo"].ToString();
                if (String.IsNullOrEmpty(email.Trim()))
                {
                    MessageBox.Show("El cliente no tiene un email registrado", "No se puede enviar un correo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                using (EnviarCorreo nuevaVentana = new EnviarCorreo(email))
                {
                    nuevaVentana.ShowDialog();
    
                }
            }

            catch
            {
                MessageBox.Show("Ocurrió un error al abrir el navegador");
            }
            finally
            {
                sql.CerrarConexion();
            }
        }

        private void ListadoClientes_Load(object sender, System.EventArgs e)
        {

        }
    }
}
