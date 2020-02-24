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
    public partial class MenusPrincipal : Form
    {
        public MenusPrincipal()
        {
            InitializeComponent();
            customizeDesing();
        }
        private void customizeDesing()
        {
            panel1Ventas.Visible = false;
            panel2SubMenu.Visible = false;
            panel2Articulos.Visible = false;
        }
        private void hideMenu()
        {
            if (panel2SubMenu.Visible == true)
                panel2SubMenu.Visible = false;
            if (panel1Ventas.Visible == true) 
                panel1Ventas.Visible = false;
            if (panel2Articulos.Visible == true)
                panel2Articulos.Visible = false;

        }
        private void showSubmenu(Panel submenu)
        {
            if (submenu.Visible == false)

            {
                hideMenu();
                submenu.Visible = true;
            }
            else
                submenu.Visible = false;

        }

        
        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void MenusPrincipal_Load(object sender, EventArgs e)
        {
            ////frmLogin menu = new frmLogin
            ////{
            ////    MdiParent = this
            ////};
            ////menu.Show();
           // panel1MENU.Visible =false;
            panel2SubMenu.Visible = false;
            panel2Articulos.Visible = false;
            panel1Ventas.Visible = false;
        }

        private void panel1MENU_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            Form fomulario = new FormAgregar();
            fomulario.Show();
            hideMenu();
        }

        private void btnClientes_Click(object sender, EventArgs e)
        {
            showSubmenu(panel2SubMenu);
        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            Form formulario1 = new FormModificarClientes();
            formulario1.Show();
            hideMenu();
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            Form fomrmulario2 = new FormElimiarClientes();
            fomrmulario2.Show();
            hideMenu();
        }

        private void btnListaArticulos_Click(object sender, EventArgs e)
        {
            showSubmenu(panel2Articulos);
        }

        private void btnAgregarArticulos_Click(object sender, EventArgs e)
        {
            Form fomulario3 = new FormAgregarArticulos();
            fomulario3.Show();
            hideMenu();
        }

        private void btnModificarArticulos_Click(object sender, EventArgs e)
        {
            Form fomulario4 = new FormModificarArticulos();
            fomulario4.Show();
            hideMenu();
        }

        private void btnElimiarArticulos_Click(object sender, EventArgs e)
        {
            Form formulario5 = new FormEliminarArticulos();
            formulario5.Show();
            hideMenu();
        }

        private void btnVentas_Click(object sender, EventArgs e)
        {
            showSubmenu(panel1Ventas);
        }

        private void btnArticulosVendidos_Click(object sender, EventArgs e)
        {
            Form fomulario6 = new FormArticulosVendidos();
            fomulario6.Show();
            hideMenu();
        }

        private void btnVendidoACliente_Click(object sender, EventArgs e)
        {
            Form fomulario7 = new FormVendidoACliente();
            fomulario7.Show();
            hideMenu();
        }

        private void btnAyuda_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Forcadell...!Gracias por se parte nuestro,,favor elegir una opcion; use nuestro correo para informarnos ");
        }

        private void btnSalirSistema_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            MessageBox.Show("Empleado Digite su clave");
            hideMenu();
        }

        private void radioVisitantes_CheckedChanged(object sender, EventArgs e)
        {
            string visitas = "visitante";
            MessageBox.Show(visitas);
            //radioVisitantes.Visible = false;
            hideMenu();
        }
    }
}
