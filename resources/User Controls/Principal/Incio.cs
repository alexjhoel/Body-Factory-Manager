using System;
using System.Collections.Generic;
using System.Configuration;
using System.Windows.Forms;

namespace Body_Factory_Manager
{
    public partial class Incio : UserControl
    {
        SQL sql;
        public Incio()
        {
            InitializeComponent();
            sql = new SQL(Properties.Settings.Default.StardustEssentialsConnectionString);

            CargarVencidas();
        }

        private void CargarVencidas()
        {
            vencidasDGV.Columns.Clear();
            Dictionary<string, object> parametros = new Dictionary<string, object>();
            parametros.Add("hoy", DateTime.Now);
            string consulta = "SELECT cedula as Cedula, CONCAT(nombre, ' ', apellido) as 'Nombre completo', FullMensualidades.id, vencimiento as Vencimiento " +
                "FROM(SELECT Mensualidades.id, pagado, valor, descuento, fechaCreado, vencimiento, cedulaCliente " +
                "FROM(SELECT Mensualidades.id, (ISNULL(SUM(monto), 0)) AS pagado " +
                "FROM Mensualidades " +
                "LEFT JOIN Pagos ON Pagos.idMensualidad = Mensualidades.id  " +
                "GROUP BY Mensualidades.id) AS PagosMensualidades " +
                "INNER JOIN Mensualidades ON PagosMensualidades.id = Mensualidades.id) as FullMensualidades " +
                "INNER JOIN Clientes on FullMensualidades.cedulaCliente = Clientes.cedula WHERE " +
                "((valor * (1 - descuento / 100)) - pagado) > 0 AND DATEDIFF(day, @hoy, vencimiento) < 5";
            vencidasDGV.DataSource = sql.Obtener(consulta, parametros);
        }
    }
}
