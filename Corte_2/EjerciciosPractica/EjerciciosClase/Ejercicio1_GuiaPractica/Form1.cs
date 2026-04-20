using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace Ejercicio1_GuiaPractica
{
    public partial class Form1 : Form
    {
        private string dataFile;

        public Form1()
        {
            InitializeComponent();
            dataFile = Path.Combine(Application.StartupPath, "productos.csv");
            LoadProducts();
        }

        private void buttonCreate_Click(object sender, EventArgs e)
        {
            var nombre = textBox1.Text.Trim();
            var codigo = textBox2.Text.Trim();
            var costo = numericUpDownCost.Value;
            var cantidad = numericUpDownQuantity.Value;

            var line = $"{nombre},{codigo},{costo},{cantidad}";

            try
            {
                File.AppendAllText(dataFile, line + Environment.NewLine);
                // Optionally clear inputs
                textBox1.Clear();
                textBox2.Clear();
                numericUpDownCost.Value = 0;
                numericUpDownQuantity.Value = 0;

                LoadProducts();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al guardar el producto:\n" + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void buttonUpdate_Click(object sender, EventArgs e)
        {
            LoadProducts();
        }

        private void LoadProducts()
        {
            listBoxProducts.Items.Clear();
            try
            {
                if (File.Exists(dataFile))
                {
                    var lines = File.ReadAllLines(dataFile);
                    foreach (var l in lines)
                    {
                        if (!string.IsNullOrWhiteSpace(l))
                            listBoxProducts.Items.Add(l);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al leer el archivo:\n" + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
