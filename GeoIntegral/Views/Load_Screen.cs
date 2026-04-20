using System;
using System.Drawing;
using System.Media;
using System.Windows.Forms;

namespace GeoIntegral.Views
{
    public partial class Load_Screen : Form
    {
        public Load_Screen()
        {
            InitializeComponent();
            tmrFadeIn.Interval = 3;
        }

        private void Load_Screen_Load(object sender, EventArgs e)
        {
            this.DoubleBuffered = true;
            this.Opacity = 0;
            tmrFadeIn.Start();
        }

        private void tmrFadeIn_Tick(object sender, EventArgs e)
        {

            if (Barra_Carga.Value < 100)
            {
                Barra_Carga.Value += 1;
            }
            else
            {
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void txtUsuario_Login_TextChanged(object sender, EventArgs e)
        {
            if (txtUsuario_Login.Text == "")
            {
                lblMensaje1.Visible = true;
            }
            else
            {
                lblMensaje1.Visible = false;
            }
        }

        private void txtContraseña_Login_TextChanged(object sender, EventArgs e)
        {
            if (txtContraseña_Login.Text == "")
            {
                lblMensaje2.Visible = true;
            }
            else
            {
                lblMensaje2.Visible = false;
            }
        }

        private void guna2Button1_Click(object sender, EventArgs e)
        {
            if (txtUsuario_Login.Text == "" || txtContraseña_Login.Text == "")
            {
                SystemSounds.Beep.Play();
                Error_MSG error_MSG = new Error_MSG();
                error_MSG.StartPosition = FormStartPosition.CenterParent;
                error_MSG.ShowDialog(this);
            }
            else
            {
                Login_Screen loginScreen = new Login_Screen();
                loginScreen.Show();
                this.Hide();
            }
        }

        private void label2_Click(object sender, EventArgs e)
        {
            // Load_Screen.Owner = this;
            this.Hide();
            Register_User NuevaCuenta = new Register_User();
            NuevaCuenta.StartPosition = FormStartPosition.CenterParent;
            NuevaCuenta.ShowDialog(this);
        }
    }
}