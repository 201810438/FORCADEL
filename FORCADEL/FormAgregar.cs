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
    public partial class FormAgregar : Form
    {
        public FormAgregar()
        {
            InitializeComponent();
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            txtApellidos.Text = "";
            txtNombres.Text = "";
            txtDireccion.Text = "";
            txtTelefono.Text = "";
            txtCedula.Text = "";
            txtCiudad.Text = "";
            txtTipoCliente.Text = "";
            txtEmail.Text = "";
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
