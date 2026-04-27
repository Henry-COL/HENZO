using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace app_inventario.Views
{
    public partial class Music_Store : Form
    {
        public Music_Store()
        {
            InitializeComponent();
        }

        private void guna2Button4_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void guna2Button2_Click(object sender, EventArgs e)
        {
            txtTitulo.Text = "";
            txtArtista.Text = "";
            txtCodigoArticulo.Text = "";
            CmbTipo.SelectedIndex = -1;
            numCantidadInicial.Value = 1;
            numPrecioArticulo.Value = 1000;
            picPrevisualizacion.Image = null;
        }

        private void guna2Button5_Click(object sender, EventArgs e)
        {
            // Crear la instancia del buscador de archivos
            OpenFileDialog buscador = new OpenFileDialog();

            // Configurar el filtro para que solo acepte .png
            buscador.Filter = "Archivos de Imagen PNG (*.png)|*.png";
            buscador.Title = "Seleccionar imagen PNG";

            // Mostrar el cuadro de diálogo y verificar si el usuario aceptó
            if (buscador.ShowDialog() == DialogResult.OK)
            {
                // Obtener la ruta del archivo seleccionado
                string rutaArchivo = buscador.FileName;

                // Ejemplo: Mostrar la ruta en un label o cargarla en un PictureBox
                picPrevisualizacion.ImageLocation = rutaArchivo;

                MessageBox.Show("Archivo cargado con éxito.");
            }
        }
    }
}