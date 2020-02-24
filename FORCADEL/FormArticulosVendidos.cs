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
    public partial class FormArticulosVendidos : Form
    {
        public FormArticulosVendidos()
        {
            InitializeComponent();
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            txtIdArticulos.Text = "";
            txtCodigoArticulo.Text = "";
            txtNumeroFactura.Text = "";
            txtDescripcionArticulos.Text = "";
        }

        private void FormArticulosVendidos_Load(object sender, EventArgs e)
        {

        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
