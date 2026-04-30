using app_inventario.Controllers;
using app_inventario.Models;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace app_inventario.Views
{
    public partial class Music_Store : Form
    {
        // ── Variables de la clase ─────────────────────────────────────
        private string rutaImagenTemporal = "";
        private ArticuloController miControlador = new ArticuloController();

        // ── Constructor ───────────────────────────────────────────────
        public Music_Store()
        {
            InitializeComponent();
            CargarDatosTabla(); // Cargamos la tabla al abrir el formulario
        }

        // ── Botón SALIR ───────────────────────────────────────────────
        private void guna2Button4_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        // ── Botón LIMPIAR campos ──────────────────────────────────────
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

        // ── Botón SUBIR PORTADA ───────────────────────────────────────
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

        // ── Botón REGISTRAR artículo ──────────────────────────────────
        private void guna2Button1_Click(object sender, EventArgs e)
        {
            // 1. Validaciones básicas
            if (string.IsNullOrWhiteSpace(txtCodigoArticulo.Text))
            {
                MessageBox.Show("El código es obligatorio.", "Aviso");
                return;
            }

            if (string.IsNullOrWhiteSpace(txtTitulo.Text))
            {
                MessageBox.Show("El título es obligatorio.", "Aviso");
                return;
            }

            if (CmbTipo.SelectedIndex == -1)
            {
                MessageBox.Show("Debes seleccionar un tipo.", "Aviso");
                return;
            }

            // 2. Verificar que el código no esté repetido
            if (miControlador.CodigoExiste(txtCodigoArticulo.Text))
            {
                MessageBox.Show("Ya existe un artículo con ese código.", "Aviso");
                return;
            }

            // 3. Crear el objeto Articulo con los datos del formulario
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

            // 4. Guardar en el CSV usando el controlador
            miControlador.RegistrarEnCsv(nuevo);
            MessageBox.Show("¡Artículo registrado con éxito!", "Éxito");

            // 5. Refrescar tabla y limpiar campos
            CargarDatosTabla();
            guna2Button2_Click(null, null);
        }

        // ── Cargar y mostrar datos en el DataGrid ─────────────────────
        private void CargarDatosTabla()
        {
            MostrarDatos1.DataSource = null;

            List<Articulo> lista = miControlador.CargarDesdeCsv();

            // ── LÍNEA TEMPORAL DE DIAGNÓSTICO ──
            MessageBox.Show($"Artículos encontrados: {lista.Count}");


            // Si no hay datos, no hacemos nada más
            if (lista == null || lista.Count == 0) return;

            // Asignamos la lista como fuente de datos
            MostrarDatos1.DataSource = lista;

            // ── Nombres de columnas en español ────────────────────────
            MostrarDatos1.Columns["Codigo"].HeaderText = "Código";
            MostrarDatos1.Columns["Titulo"].HeaderText = "Título";
            MostrarDatos1.Columns["Artistas"].HeaderText = "Artistas";
            MostrarDatos1.Columns["TipoArticulo"].HeaderText = "Tipo";
            MostrarDatos1.Columns["Cantidad"].HeaderText = "Stock";
            MostrarDatos1.Columns["Precio"].HeaderText = "Precio";

            // ── Formato de precio con puntos de miles ─────────────────
            MostrarDatos1.Columns["Precio"].DefaultCellStyle.Format = "N0";

            // ── Ocultar columna de ruta de imagen ─────────────────────
            if (MostrarDatos1.Columns["RutaPortada"] != null)
                MostrarDatos1.Columns["RutaPortada"].Visible = false;

            // ── Estilo visual ─────────────────────────────────────────
            MostrarDatos1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            MostrarDatos1.ColumnHeadersHeight = 35;
        }

        private void Music_Store_Load(object sender, EventArgs e) { }
    }
}