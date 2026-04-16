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
    public partial class Olvido_Contraseña : Form
    {
        public Olvido_Contraseña()
        {
            InitializeComponent();
        }
        string CorreoRegistrado = "prueba@gmail.com";

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == CorreoRegistrado)
            {
                MessageBox.Show("Se ha enviado un correo de recuperación a tu dirección de correo electrónico registrada.", "Recuperación de Contraseña", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("El correo electrónico ingresado no coincide con ningún registro. Por favor, verifica tu dirección de correo electrónico.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
