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

        }

        private void listarBTN_Click(object sender, EventArgs e)
        {
            using (ListadoMensualidades nuevaVentana = new ListadoMensualidades())
            {
                nuevaVentana.ShowDialog();
            }
        }

        private void nuevaCuotaBTN_Click(object sender, EventArgs e)
        {
            using (DatosMensualidad nuevaVentana = new DatosMensualidad())
            {
                nuevaVentana.ShowDialog();
            }
        }

        private void nuevoPagoBTN_Click(object sender, EventArgs e)
        {
            using (DatosPago nuevaVentana = new DatosPago(""))
            {
                nuevaVentana.ShowDialog();
            }
        }
    }
}
