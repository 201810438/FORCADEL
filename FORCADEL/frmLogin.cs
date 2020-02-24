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
    public partial class frmLogin : Form
    {
        public frmLogin()
        {
            InitializeComponent();

        }

        public void btnAceptar_Click(object sender, EventArgs e)
        {
            MenusPrincipal MenuPrincial = new MenusPrincipal();
            MenuPrincial.Show();
           //this.Close();
            
            MenusPrincipal menu = new MenusPrincipal();
            this.Hide();
            menu.ShowDialog();
            this.Close();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
           // btnAceptar.Show();
        }

        private void textBox1_Enter(object sender, EventArgs e)
        {
            if(textBox1.Text == "Usuario")
            {
                textBox1.Text = "";
                textBox1.ForeColor = Color.White;               
            }
        }

        private void textBox1_Leave(object sender, EventArgs e)
        {
            if(textBox1.Text=="")
            {
                textBox1.Text = "Usuario";
                textBox1.ForeColor = Color.White;
            }
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void textBox2_Leave(object sender, EventArgs e)
        {
            if (textBox2.Text == "")
            {
                textBox2.Text = "Clave";
                textBox2.ForeColor = Color.White;
            }
            
        }

        private void textBox2_Enter(object sender, EventArgs e)
        {
            if (textBox2.Text == "Clave")
            {
                textBox2.Text = "";
                textBox2.ForeColor = Color.White;
            }
             
        }

        private void pictureBoxCerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
            
        }
        
    }

}
