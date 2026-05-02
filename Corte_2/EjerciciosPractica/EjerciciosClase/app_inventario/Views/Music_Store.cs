using app_inventario.Controllers;
using app_inventario.Models;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace app_inventario.Views
{
    public partial class Music_Store : Form
    {
        private ArticuloController _controller;
        // ── Variables de la clase ─────────────────────────────────────
        private string rutaImagenTemporal = "";
        private ArticuloController miControlador = new ArticuloController();

        // ── Constructor ───────────────────────────────────────────────
        public Music_Store()
        {
            _controller = new ArticuloController();
            InitializeComponent();
            CargarComboBoxMusica();
            CargarDatosTabla(); // Cargamos la tabla al abrir el formulario

            MostrarDatos1.ClearSelection();
            MostrarDatos1.CurrentCell = null;
        }


        private void CargarComboBoxMusica()
        {
            var items = _controller.ObtenerMusicaParaComboBox();
            cmbMusica_Lista.Items.Clear();                    // ← Tu ComboBox
            cmbMusica_Lista.Items.AddRange(items.ToArray());

            if (cmbMusica_Lista.Items.Count > 0)
                cmbMusica_Lista.SelectedIndex = 0;
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
            if (lista == null || lista.Count == 0) return;

            MostrarDatos1.DataSource = lista;

            var cols = MostrarDatos1.Columns;
            cols["Codigo"].HeaderText = "Código";
            cols["Titulo"].HeaderText = "Título";
            cols["Artistas"].HeaderText = "Artistas";
            cols["TipoArticulo"].HeaderText = "Tipo";
            cols["Cantidad"].HeaderText = "Stock";
            cols["Precio"].HeaderText = "Precio";
            cols["Precio"].DefaultCellStyle.Format = "N0";
            if (cols["RutaPortada"] != null) cols["RutaPortada"].Visible = false;

            Color fondo = Color.FromArgb(15, 52, 67);
            Color fondoAlt = Color.FromArgb(5, 32, 41);
            Font fuente = new Font("Segoe UI", 9.5f);

            MostrarDatos1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            MostrarDatos1.ColumnHeadersHeight = 35;
            MostrarDatos1.EnableHeadersVisualStyles = false;

            MostrarDatos1.ColumnHeadersDefaultCellStyle.BackColor = fondoAlt;
            MostrarDatos1.ColumnHeadersDefaultCellStyle.ForeColor = Color.White;
            MostrarDatos1.ColumnHeadersDefaultCellStyle.Font = new Font("Montserrat SemiBold", 10f, FontStyle.Bold);

            MostrarDatos1.DefaultCellStyle.BackColor = fondo;
            MostrarDatos1.DefaultCellStyle.ForeColor = Color.White;
            MostrarDatos1.DefaultCellStyle.Font = fuente;
            MostrarDatos1.DefaultCellStyle.SelectionBackColor = Color.FromArgb(0, 120, 160);
            MostrarDatos1.DefaultCellStyle.SelectionForeColor = Color.White;

            MostrarDatos1.AlternatingRowsDefaultCellStyle.BackColor = fondoAlt;
            MostrarDatos1.AlternatingRowsDefaultCellStyle.ForeColor = Color.White;
            MostrarDatos1.AlternatingRowsDefaultCellStyle.Font = fuente;

            MostrarDatos1.RowsAdded += (s, e) =>
            {
                for (int i = e.RowIndex; i < e.RowIndex + e.RowCount; i++)
                    if (i < MostrarDatos1.Rows.Count)
                        MostrarDatos1.Rows[i].DefaultCellStyle.BackColor = i % 2 == 0 ? fondo : fondoAlt;
            };


        }

        private void Music_Store_Load(object sender, EventArgs e) { }
    }
}