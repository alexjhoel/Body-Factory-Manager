using System.Windows.Forms;

namespace Body_Factory_Manager
{
    public partial class SelectorClientes : Form
    {
        public string id;
        public SelectorClientes(FiltroBusqeda filtro = null)
        {
            InitializeComponent();
            listado = new SeccionClientes(null,true, filtro, this.Seleccionar);

            listado.Dock = DockStyle.Fill;

            this.Controls.Add(listado);

            DialogResult = DialogResult.Cancel;

        }

        private void Seleccionar(string id)
        {
            if (string.IsNullOrEmpty(id))
            {
                MessageBox.Show("Ningun cliente seleccionado");
                return;
            }
            DialogResult = DialogResult.OK;
            this.id = id;
            this.Close();
        }


    }
}
