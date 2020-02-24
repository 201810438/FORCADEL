using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FORCADEL
{
    public partial class FormModificarArticulos : Form
    {
        public FormModificarArticulos()
        {
            InitializeComponent();
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            txtIdArticulos.Text = "";
            txtCodigoArticulos.Text = "";
            txtNombreArticulos.Text = "";
            txtDescripcionArticulos.Text = "";
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
