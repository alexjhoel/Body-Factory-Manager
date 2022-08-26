using System;
using System.Windows.Forms;

namespace Body_Factory_Manager
{
    public partial class BuscadorClientes : Form
    {
        public string consulta;
        public FiltroBusqeda filtro1;
        public FiltroBusqeda filtro2;


        private FiltroBusqeda[] filtrosPrefijados = { new FiltroBusqeda("Nombre","Nombre", TipoFiltro.String),
        new FiltroBusqeda("Apellido","apellido", TipoFiltro.String),
        new FiltroBusqeda("Cédula","cedula", TipoFiltro.String)};

        public BuscadorClientes()
        {
            InitializeComponent();
            buscador = new Buscador(Buscar, Descartar, filtrosPrefijados);
            this.Controls.Add(buscador);
            buscador.Dock = DockStyle.Fill;
        }

        private void BuscadorClientes_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
        }

        private void busqueda1ANUD_ValueChanged(object sender, EventArgs e)
        {

        }

        private void Descartar()
        {
            DialogResult = DialogResult.Cancel;
            this.Close();
        }
        private void Buscar(FiltroBusqeda filtro1)
        {
            DialogResult = DialogResult.OK;
            //MessageBox.Show(filtro1.valor1 + "ADSAd");
            this.filtro1 = filtro1;
            this.Close();
        }

        

        
    }


    
}
