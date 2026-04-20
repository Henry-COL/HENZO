using System;
using System.IO;
using System.Windows.Forms;

namespace VentasDiarias
{
    public partial class Form1 : Form
    {
        string ruta = "ventas.csv";

        public Form1()
        {
            InitializeComponent();
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            string id = txtId.Text;
            double monto = (double)numMonto.Value;

            string linea = id + "," + monto;

            File.AppendAllText(ruta, linea + Environment.NewLine);

            txtId.Clear();
            numMonto.Value = 0;
        }

        private void btnCargar_Click(object sender, EventArgs e)
        {
            listBox1.Items.Clear();
            double total = 0;

            if (File.Exists(ruta))
            {
                string[] lineas = File.ReadAllLines(ruta);

                foreach (string linea in lineas)
                {
                    listBox1.Items.Add(linea);

                    string[] datos = linea.Split(',');
                    double monto = Convert.ToDouble(datos[1]);
                    total += monto;
                }
            }

            lblTotal.Text = "TOTAL: $" + total.ToString("N2");
        }
    }
}