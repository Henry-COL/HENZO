using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProyectoIntegrador
{
    public partial class Login : Form
    {

        public Login()
        {

            InitializeComponent();
        }

        private void Login_Load(object sender, EventArgs e)
        {

        }

        private void btnCerrrar_Login_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void txtUser_Login_TextChanged(object sender, EventArgs e)
        {

            if (!string.IsNullOrWhiteSpace(txtUser_Login.Text))
            {
                lblMensaje_Usuario_Login.Visible = false;
                lblError_Usuario_Login.Visible = false;
            }
            else
            {
                lblMensaje_Usuario_Login.Visible = true;
                lblError_Usuario_Login.Visible = true;
            }
        }

        private void txtContraseña_Login_TextChanged(object sender, EventArgs e)
        {
            txtContraseña_Login.UseSystemPasswordChar = true;
            if (!string.IsNullOrWhiteSpace(txtContraseña_Login.Text))
            {
                lblMensaje_Contraseña_Login.Visible = false;
                lblError_Contraseña_Login.Visible = false;
            }
            else
            {
                lblMensaje_Contraseña_Login.Visible = true;
                lblError_Contraseña_Login.Visible = true;
            }
        }

        private void lblOlvidoContraseña_Login_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Funcionalidad de recuperación de contraseña no implementada.");
        }

        private void lblRegistrarse_Login_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Funcionalidad de registro no implementada.");
        }

        private void btnMostarContraseña_Login_Click(object sender, EventArgs e)
        {
            txtContraseña_Login.UseSystemPasswordChar = !txtContraseña_Login.UseSystemPasswordChar;
        }
    }
}
