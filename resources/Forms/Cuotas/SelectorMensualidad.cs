using System.Drawing;
using System.Windows.Forms;

namespace Body_Factory_Manager
{
    public partial class SelectorMensualidad : Form
    {
        public string id;
        SeccionMensualidades selectorMensualidad;
        public SelectorMensualidad(FiltroBusqeda filtro)
        {

            InitializeComponent();
            DialogResult = DialogResult.Cancel;
            selectorMensualidad = new SeccionMensualidades(true, filtro, this.Seleccionar);
            this.Controls.Add(selectorMensualidad);
            selectorMensualidad.Location = new Point(0, 0);
            selectorMensualidad.Size = new Size(this.Size.Width, 420);
            selectorMensualidad.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
        }

        private void Seleccionar(string id)
        {
            DialogResult = DialogResult.OK;
            this.id = id;
            this.Close();
        }
    }
}
