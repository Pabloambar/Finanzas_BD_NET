using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Finanzas
{
    public partial class frmPassword : Form
    {
        public frmPassword()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string Usuario = txtUsuario.Text;
            string Password = txtPassword.Text;

            if (Usuario is "x"  && Password is "x" || Usuario is "x" && Password is "x" || Usuario is "x" && Password is "x")
            {
                frmPrincipal principal = new frmPrincipal();
                principal.Show();
                this.Hide();
                
              
            }
            else
            {
                MessageBox.Show("Contraseña o usuario incorrectos");
            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            
            string Usuario = txtUsuario.Text;
            string Password = txtPassword.Text;

            if (Password is "" || Usuario is "")
            {
                btnIngresar.Enabled = false;
            }
            else
            {
                btnIngresar.Enabled = true;
            }
        }

        private void frmPassword_Load(object sender, EventArgs e)
        {
            MessageBox.Show("Usuario: x | Contraseña: x");
            btnIngresar.Enabled = false;
            
        }

        private void txtPassword_TextChanged(object sender, EventArgs e)
        {
            string Usuario = txtUsuario.Text;
            string Password = txtPassword.Text;

            if (Password is "" || Usuario is "")
            {
                btnIngresar.Enabled = false;
            }
            else
            {

                btnIngresar.Enabled = true;
            }
        }

        private void btnBorrar_Click(object sender, EventArgs e)
        {
            txtUsuario.Text = "";
            txtPassword.Text = "";

        }
    }
}
