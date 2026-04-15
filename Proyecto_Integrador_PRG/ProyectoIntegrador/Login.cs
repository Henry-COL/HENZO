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

            if (string.IsNullOrWhiteSpace(txtUser_Login.Text))
            {
                lblError_Usuario_Login.Visible = true;
                lblMensaje_Usuario_Login.Visible = true;
            }
            else
            {
                lblMensaje_Usuario_Login.Visible = false;

            }
        }

        private void txtContraseña_Login_TextChanged(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtContraseña_Login.Text))
            {
                lblError_Contraseña_Login.Visible = true;
            }
            else
            {
                lblMensaje_Contraseña_Login.Visible = false;

            }
        }
    }
}
