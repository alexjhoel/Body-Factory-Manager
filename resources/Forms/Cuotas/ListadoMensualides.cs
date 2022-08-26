using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Body_Factory_Manager
{
    public partial class ListadoMensualidades : Form
    {
        SQL sql = new SQL(ConfigurationManager.ConnectionStrings["Body_Factory_Manager.Properties.Settings.StardustEssentialsConnectionString"].ConnectionString);
        string consulta;

        public string id;
        public ListadoMensualidades(string consulta = null, bool selector = false)
        {
            this.consulta = consulta;

            InitializeComponent();

            DialogResult = DialogResult.Cancel;
            if (this.consulta == null)
            {
                this.consulta = "SELECT TodoMensualidades.id, CONCAT('$',valor) as Cuota, CONCAT(descuento,'%') as Descuento, CONCAT('$',(valor * (1 - descuento / 100))) as Total, CONCAT('$',((valor * (1 - descuento / 100)) - pagado)) as Deuda, vencimiento as Vencimiento " +
                    "FROM(SELECT Mensualidades.id as id, (ISNULL(SUM(monto), 0)) AS pagado " +
                    "FROM Mensualidades LEFT JOIN Pagos ON Pagos.idMensualidad = Mensualidades.id " +
                    "GROUP BY Mensualidades.id) AS TodoMensualidades INNER JOIN Mensualidades ON TodoMensualidades.id = Mensualidades.id";
            }




            List<ListadoButtonDatos> buttonDatos = new List<ListadoButtonDatos>();
            if (selector)
            {
                buttonDatos.Add(new ListadoButtonDatos("Listo", Body_Factory_Manager.Properties.Resources.check, this.Seleccionar));
                buttonDatos.Add(new ListadoButtonDatos("Ver", Body_Factory_Manager.Properties.Resources.ver, this.Editar));

            }
            else
            {
                buttonDatos.Add(new ListadoButtonDatos("Editar", Body_Factory_Manager.Properties.Resources.editar, this.Editar));
                buttonDatos.Add(new ListadoButtonDatos("Pagar", Body_Factory_Manager.Properties.Resources.signo_de_dolar, this.PagarCuota));
                buttonDatos.Add(new ListadoButtonDatos("Borrar", Body_Factory_Manager.Properties.Resources.eliminar, this.Eliminar));
            }


            listado = new Listado("id", buttonDatos);
            this.Controls.Add(listado);
            listado.Location = new Point(0, 0);
            listado.Size = new Size(this.Size.Width,420);
            listado.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            CargarListaMensualidades();



        }


        private void Eliminar(string id)
        {
            if (MessageBox.Show("Confirmar borrado", "¿Esta seguro que quiere eliminar el cliente?", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.No) return;
            sql.Modificar("DELETE FROM Mensualidades WHERE id= " + id);
            CargarListaMensualidades();
        }

        private void CargarListaMensualidades()
        {
            listado.datos = sql.Obtener(consulta);
            listado.Recargar("id");
        }

        private void Editar(string id)
        {
            using (DatosCliente nuevaVentana = new DatosCliente("", id))
            {
                nuevaVentana.ShowDialog();
            }
        }

        private void Seleccionar(string id)
        {
            DialogResult = DialogResult.OK;
            this.id = id;
            this.Close();
        }

        private void PagarCuota(string cedula)
        {


            using (DatosMensualidad nuevaVentana = new DatosMensualidad(cedula, TipoPagoMensualidad.PagarCuotaDesdeClientes))
            {
                nuevaVentana.ShowDialog();
            }
        }
        private void ActualizarConsulta()
        {
            if (pagasCBX.Checked)
            {
                consulta = "SELECT TodoMensualidades.id, CONCAT('$',valor) as Cuota, CONCAT(descuento,'%') as Descuento, CONCAT('$',(valor * (1 - descuento / 100))) as Total, CONCAT('$',((valor * (1 - descuento / 100)) - pagado)) as Deuda, vencimiento as Vencimiento " +
                    "FROM(SELECT Mensualidades.id as id, (ISNULL(SUM(monto), 0)) AS pagado " +
                    "FROM Mensualidades LEFT JOIN Pagos ON Pagos.idMensualidad = Mensualidades.id " +
                    "GROUP BY Mensualidades.id) AS TodoMensualidades INNER JOIN Mensualidades ON TodoMensualidades.id = Mensualidades.id";

            }
            else
            {
                consulta = "SELECT TodoMensualidades.id, CONCAT('$',valor) as Cuota, CONCAT(descuento,'%') as Descuento, CONCAT('$',(valor * (1 - descuento / 100))) as Total, CONCAT('$',((valor * (1 - descuento / 100)) - pagado)) as Deuda, vencimiento as Vencimiento " +
                    "FROM (SELECT Mensualidades.id as id, (ISNULL(SUM(monto), 0)) AS pagado " +
                    "FROM Mensualidades LEFT JOIN Pagos ON Pagos.idMensualidad = Mensualidades.id " +
                    "GROUP BY Mensualidades.id) AS TodoMensualidades INNER JOIN Mensualidades ON TodoMensualidades.id = Mensualidades.id " +
                    "WHERE ((valor * (1 - descuento / 100)) - pagado) > 0";
            }
            
            CargarListaMensualidades();
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            ActualizarConsulta();
        }
    }
}
