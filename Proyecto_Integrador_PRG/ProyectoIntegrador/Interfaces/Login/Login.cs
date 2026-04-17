using ProyectoIntegrador.Interfaces.Mensajes_Error;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Media;
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
            this.DoubleBuffered = true;
        }


        private void Login_Load(object sender, EventArgs e)
        {
            RedondearControl(Fondo_Inicio, 14);
            RedondearControl(txtUser_Login, 9);
            RedondearControl(txtContraseña_Login, 9);
            RedondearForm(17);

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
            this.Hide();
            Olvido_Contraseña RecuperarContraseña = new Olvido_Contraseña();
            RecuperarContraseña.FormClosed += (s, args) => this.Show();
            RecuperarContraseña.Show();
        }

        private void lblRegistrarse_Login_Click(object sender, EventArgs e)
        {
            this.Hide();
            Registro_App NuevaCuenta = new Registro_App();
            NuevaCuenta.FormClosed += (s, args) => this.Show();
            NuevaCuenta.Show();
        }

        private void btnMostarContraseña_Login_Click(object sender, EventArgs e)
        {
            txtContraseña_Login.UseSystemPasswordChar = !txtContraseña_Login.UseSystemPasswordChar;
        }

        private void btnIniciarSesion_Login_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtUser_Login.Text) || string.IsNullOrWhiteSpace(txtContraseña_Login.Text))
            {
                string mensajeError = "Para poder iniciar sesión, debes completar\nlos campos requeridos primero.";
                Mensaje_Error_Basico error_login = new Mensaje_Error_Basico(mensajeError);
                error_login.FormClosed += (s, args) => this.Show();
                error_login.Show();

                // Sonido personalizado:
                SystemSounds.Beep.Play();

                return;
            }
            else if (!string.IsNullOrWhiteSpace(txtUser_Login.Text) && !string.IsNullOrWhiteSpace(txtContraseña_Login.Text))
            {
                MessageBox.Show("Inicio de sesión exitoso (simulado).");
            }
        }


        //Bordes Redondeados
        private void RedondearControl(Control control, int radio)
        {
            GraphicsPath gp = new GraphicsPath();
            // Crea un arco en cada esquina para formar el radio de 14px
            gp.AddArc(0, 0, radio, radio, 180, 90);
            gp.AddArc(control.Width - radio, 0, radio, radio, 270, 90);
            gp.AddArc(control.Width - radio, control.Height - radio, radio, radio, 0, 90);
            gp.AddArc(0, control.Height - radio, radio, radio, 90, 90);
            gp.CloseAllFigures();

            control.Region = new Region(gp);
        }

        private void RedondearForm(int radio)
        {
            GraphicsPath gp = new GraphicsPath();
            gp.AddArc(0, 0, radio, radio, 180, 90);
            gp.AddArc(this.Width - radio, 0, radio, radio, 270, 90);
            gp.AddArc(this.Width - radio, this.Height - radio, radio, radio, 0, 90);
            gp.AddArc(0, this.Height - radio, radio, radio, 90, 90);
            gp.CloseAllFigures();

            this.Region = new Region(gp);
        }

        private void btn_minimizar_login_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void btn_ventana_login_Click(object sender, EventArgs e)
        {

        }

        private void txtUser_Login_HelpRequested(object sender, HelpEventArgs hlpevent)
        {
            lblMensaje_Usuario_Login.Visible = true;
            lblMensaje_Usuario_Login.Text = "Ingresa tu nombre de usuario o correo electrónico registrado.";
            hlpevent.Handled = true;
        }
    }
}