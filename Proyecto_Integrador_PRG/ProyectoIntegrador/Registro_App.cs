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
    public partial class Registro_App : Form
    {
        public Registro_App()
        {
            InitializeComponent();
        }

        private void btn_RegistrarCuenta_Registrar_Click(object sender, EventArgs e)
        {
            if (txtCorreo_Registrar.Text == txtCorreo_Confirmar_Registrar.Text)
            {
                MessageBox.Show("Registro exitoso (simulado).");
                this.Close();

            }
            else
            {
                lblMensaje_Correo_Registrar.Visible = true;
                MessageBox.Show("Los correos electrónicos no coinciden. Por favor, verifica tu dirección de correo electrónico.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
