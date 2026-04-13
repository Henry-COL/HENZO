using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PWV_Ejercicio_1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            if (Nombre_box.Text == "")
            {
                Mensaje_Nombre.Visible = true;
            }
            else
            {
                Mensaje_Nombre.Visible = false;
            }
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            bool hayError = false;

            // 3. Validamos cada campo de forma independiente
            if (string.IsNullOrWhiteSpace(Nombre_box.Text))
            {
                Mensaje_Nombre.Visible = true;
                hayError = true;
            }

            if (string.IsNullOrWhiteSpace(Apellido_box.Text))
            {
                Mensaje_Apellido.Visible = true;
                hayError = true;
            }

            if (string.IsNullOrWhiteSpace(ID_box.Text))
            {
                Mensaje_ID.Visible = true;
                hayError = true;
            }

            if (string.IsNullOrWhiteSpace(Email_box.Text))
            {
                Mensaje_Email.Visible = true;
                hayError = true;
            }

            if(Tipo_Trabajo.SelectedIndex == -1)
            {
                Mensaje_TipoTrabajo.Visible = true;
                hayError = true;
            }

            if (hayError)
            {
                Mensaje_Registrar.Text = "Por favor, complete los campos requeridos.";
                Mensaje_Registrar.ForeColor = Color.Red;
                Mensaje_Registrar.Visible = true;
            }
            else
            {
                Mensaje_Registrar.Text = "¡El empleado ha sido registrado exitosamente!";
                Mensaje_Registrar.ForeColor = Color.DarkGreen;
                Mensaje_Registrar.Visible = true;
            }
        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void Apellido_box_TextChanged(object sender, EventArgs e)
        {
            if (Apellido_box.Text == "")
            {
                Mensaje_Apellido.Visible = true;
            }
            else
            {
                Mensaje_Apellido.Visible = false;
            }
        }

        private void ID_box_TextChanged(object sender, EventArgs e)
        {
            if (ID_box.Text == "")
            {
                Mensaje_ID.Visible = true;
            }
            else
            {
                Mensaje_ID.Visible = false;
            }
        }

        private void Email_box_TextChanged(object sender, EventArgs e)
        {
            if (Email_box.Text == (""))
            {
                Mensaje_Email.Visible = true;
            }

            if (Email_box.Text != (""))
            {
                Mensaje_Email.Visible = false;
            }

            if (!Email_box.Text.Contains("@") || !Email_box.Text.Contains("."))
            {
                Mensaje_Email.Text = "El correo electrónico no es válido.";
                Mensaje_Email.ForeColor = Color.Red;
                Mensaje_Email.Visible = true;
            }
            else
            {
                Mensaje_Email.Visible = false;
            }
        }

        private void Mensaje_Apellido_Click(object sender, EventArgs e)
        {

        }

        private void numericUpDown1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void Num_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click_1(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (Tipo_Trabajo.SelectedIndex == -1)
            {
                Mensaje_TipoTrabajo.Visible = true;
            }
            else
            {
                Mensaje_TipoTrabajo.Visible = false;
            }
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }
    }
}
