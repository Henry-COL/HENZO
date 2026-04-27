using app_inventario.Controllers;
using app_inventario.Models;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace app_inventario.Views
{
    public partial class Music_Store : Form
    {
        private string rutaImagenTemporal = "";
        private ArticuloController miControlador = new ArticuloController();

        public Music_Store()
        {
            InitializeComponent();
            CargarDatosTabla();
        }

        // Botón Salir
        private void guna2Button4_Click(object sender, EventArgs e) => this.Close();

        // Botón Limpiar (X)
        private void guna2Button2_Click(object sender, EventArgs e)
        {
            txtTitulo.Clear();
            txtArtista.Clear();
            txtCodigoArticulo.Clear();
            CmbTipo.SelectedIndex = -1;
            numCantidadInicial.Value = 1;
            numPrecioArticulo.Value = 1000;
            picPrevisualizacion.Image = null;
            rutaImagenTemporal = "";
        }

        // Botón Subir Portada
        private void guna2Button5_Click(object sender, EventArgs e)
        {
            OpenFileDialog buscador = new OpenFileDialog();
            buscador.Filter = "PNG Files (*.png)|*.png";
            if (buscador.ShowDialog() == DialogResult.OK)
            {
                rutaImagenTemporal = buscador.FileName;
                picPrevisualizacion.ImageLocation = rutaImagenTemporal;
            }
        }

        // Botón Registrar Artículo (Verde)
        private void guna2Button1_Click(object sender, EventArgs e)
        {
            try
            {
                if (string.IsNullOrWhiteSpace(txtCodigoArticulo.Text))
                {
                    MessageBox.Show("El código es obligatorio.");
                    return;
                }

                Articulo nuevo = new Articulo
                {
                    Codigo = txtCodigoArticulo.Text,
                    Titulo = txtTitulo.Text,
                    Artistas = txtArtista.Text,
                    TipoArticulo = CmbTipo.Text,
                    Cantidad = (int)numCantidadInicial.Value,
                    Precio = numPrecioArticulo.Value,
                    RutaPortada = rutaImagenTemporal
                };

                miControlador.RegistrarEnCsv(nuevo);
                MessageBox.Show("Registrado con éxito.");

                CargarDatosTabla(); // Refrescar DataGrid
                guna2Button2_Click(null, null); // Limpiar campos
            }
            catch (Exception ex) { MessageBox.Show(ex.Message); }
        }

        private void CargarDatosTabla()
        {
            try
            {
                // 1. Limpiar fuente de datos
                MostrarDatos1.DataSource = null;

                // 2. Obtener lista desde el controlador
                List<Articulo> lista = miControlador.CargarDesdeCsv();

                // 3. Si hay datos, configuramos todo
                if (lista != null && lista.Count > 0)
                {
                    MostrarDatos1.DataSource = lista;

                    // --- CONFIGURACIÓN DE COLUMNAS ---
                    MostrarDatos1.Columns["Codigo"].HeaderText = "Código";
                    MostrarDatos1.Columns["Titulo"].HeaderText = "Título";
                    MostrarDatos1.Columns["Artistas"].HeaderText = "Artistas";
                    MostrarDatos1.Columns["TipoArticulo"].HeaderText = "Tipo";
                    MostrarDatos1.Columns["Cantidad"].HeaderText = "Stock";
                    MostrarDatos1.Columns["Precio"].HeaderText = "Precio";

                    // --- FORMATOS ---
                    // N0 pone los puntos de miles: 21000 -> 21.000
                    MostrarDatos1.Columns["Precio"].DefaultCellStyle.Format = "N0";

                    // Ocultar la ruta de la portada (importante para que no se vea feo)
                    if (MostrarDatos1.Columns["RutaPortada"] != null)
                        MostrarDatos1.Columns["RutaPortada"].Visible = false;

                    // --- ESTILO VISUAL (Para que no se vea solo una línea) ---
                    MostrarDatos1.Theme = Guna.UI2.WinForms.Enums.DataGridViewPresetThemes.Dark; // O el que prefieras
                    MostrarDatos1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
                    MostrarDatos1.ColumnHeadersHeight = 35; // Darle altura al encabezado azul
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error visual: " + ex.Message);
            }
        }
    }
}