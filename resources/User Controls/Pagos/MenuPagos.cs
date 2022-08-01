using System;
using System.Windows.Forms;

namespace Body_Factory_Manager
{
    public partial class MenuPagos : UserControl
    {
        public MenuPagos()
        {
            InitializeComponent();
        }

        private void nuevoBTN_Click(object sender, EventArgs e)
        {
            using (DatosPago nuevaVentana = new DatosPago(""))
            {
                nuevaVentana.ShowDialog();
            }

        }

        private void listarBTN_Click(object sender, EventArgs e)
        {
            using (ListadoPagos nuevaVentana = new ListadoPagos())
            {
                nuevaVentana.ShowDialog();
            }
        }
    }
}
