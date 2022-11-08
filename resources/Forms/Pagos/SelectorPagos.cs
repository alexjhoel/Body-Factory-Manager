using System.Windows.Forms;

namespace Body_Factory_Manager
{
    public partial class SelectorPagos : Form
    {
        SeccionPagos listado;
        public string id;
        public SelectorPagos(FiltroBusqeda filtro = null)
        {

            InitializeComponent();
            DialogResult = DialogResult.Cancel;
            listado = new SeccionPagos(false, filtro, this.Seleccionar, false);
            this.Controls.Add(listado);
            listado.Dock = DockStyle.Fill;
        }

        private void Seleccionar(string id)
        {
            if (string.IsNullOrEmpty(id))
            {
                MessageBox.Show("Ningun pago seleccionado");
                return;
            }
                
            DialogResult = DialogResult.OK;
            this.id = id;
            this.Close();
        }
    }
}
