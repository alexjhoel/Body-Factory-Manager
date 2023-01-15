using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Body_Factory_Manager
{
    public partial class DatosIngreso : Form
    {

        public DateTime fecha;
        public string comentario;

        public DatosIngreso()
        {
            InitializeComponent();


        }

        private void guardarBTN_Click(object sender, EventArgs e)
        {
            fecha = fechaDTP.Value;
            comentario = comentarioTbx.Text;
            DialogResult = DialogResult.Yes;
        }
    }
}
