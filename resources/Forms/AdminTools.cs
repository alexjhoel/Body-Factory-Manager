using System;
using System.Configuration;
using System.Windows.Forms;

namespace Body_Factory_Manager
{
    public partial class AdminTools : Form
    {
        SQL sql = new SQL(ConfigurationManager.ConnectionStrings["Body_Factory_Manager.Properties.Settings.StardustEssentialsConnectionString"].ConnectionString);
        public AdminTools()
        {
            InitializeComponent();
        }

        private void enviarBtn_Click(object sender, EventArgs e)
        {
            try
            {
                sql.Modificar(consultaTbx.Text);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                sql.CerrarConexion();
            }

        }

        private void recibirBtn_Click(object sender, EventArgs e)
        {
            try
            {
                tablaDGV.DataSource = sql.Obtener(consultaTbx.Text);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                sql.CerrarConexion();
            }

        }
    }
}
