using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
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
            using (DatosPago nuevaVentana = new DatosPago("")){
                nuevaVentana.ShowDialog();
            }
                
        }
    }
}
