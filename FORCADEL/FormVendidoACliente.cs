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
    public partial class FormVendidoACliente : Form
    {
        public FormVendidoACliente()
        {
            InitializeComponent();
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            txtCodigoArticulo.Text = "";
            txtDescripcionArticulos.Text = "";
            txtDescuento.Text = "";
            txtDireccionCliente.Text = "";
            txtNombreCliente.Text = "";
            txtNumeroFactura.Text = "";
            txtPrecioArticulo.Text = "";
            txtTelefonoCliente.Text = "";
            txtTotal.Text = "";
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
