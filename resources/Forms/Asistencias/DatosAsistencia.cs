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
    public partial class DatosAsistencia : Form
    {
        public bool faltaEstado;
        public string observacion;
        public DatosAsistencia(bool faltaEstado, string observacion)
        {
            
            InitializeComponent();
            this.faltaEstado = faltaEstado;
            observacionTBX.Text = observacion;
            ActualizarBoton();
            
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void ActualizarBoton()
        {
            if (faltaEstado)
            {
                asisteBTN.Text = "no";
                asisteBTN.BackColor = Color.Red;
            }
            else
            {
                asisteBTN.Text = "sí";
                asisteBTN.BackColor = Color.Green;
            }
        }
        private void button1_Click(object sender, EventArgs e)
        {
            faltaEstado = !faltaEstado;
            ActualizarBoton();
            
        }

        private void guardarBTN_Click(object sender, EventArgs e)
        {
            
            observacion = observacionTBX.Text;
            DialogResult = DialogResult.OK;
            this.Close();

        }

        private void borrarBTN_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.No;
            this.Close();
        }
    }
}
