using System;
using System.IO;
using System.Windows.Forms;

namespace RegistroClientes
{
    public partial class Form1 : Form
    {
        string ruta = "clientes.txt";

        public Form1()
        {
            InitializeComponent();
        }

        private void btnRegistrar_Click(object sender, EventArgs e)
        {
            string dni = txtDni.Text;
            string nombre = txtNombre.Text;
            string ciudad = txtCiudad.Text;

            if (dni == "" || nombre == "")
            {
                MessageBox.Show("DNI y Nombre son obligatorios");
                return;
            }

            if (ciudad == "")
            {
                ciudad = "No especificado";
            }

            string linea = dni + "," + nombre + "," + ciudad;

            File.AppendAllText(ruta, linea + Environment.NewLine);

            txtDni.Clear();
            txtNombre.Clear();
            txtCiudad.Clear();
        }

        private void btnCargar_Click(object sender, EventArgs e)
        {
            listBox1.Items.Clear();

            if (File.Exists(ruta))
            {
                string[] lineas = File.ReadAllLines(ruta);

                foreach (string linea in lineas)
                {
                    listBox1.Items.Add(linea);
                }
            }
        }
    }
}