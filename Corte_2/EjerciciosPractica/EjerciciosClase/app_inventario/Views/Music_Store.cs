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
        // Un solo controlador (antes había dos: _controller y miControlador)
        private readonly ArticuloController _controller;
        private string _rutaImagenTemporal = "";

        public Music_Store()
        {
            _controller = new ArticuloController();
            InitializeComponent();
            CargarComboBoxMusica();
            CargarDatosTabla();

            MostrarDatos1.ClearSelection();
            MostrarDatos1.CurrentCell = null;
        }

        // ── ComboBox ──────────────────────────────────────────────────
        private void CargarComboBoxMusica()
        {
            var items = _controller.ObtenerMusicaParaComboBox();
            cmbMusica_Lista.Items.Clear();
            cmbMusica_Lista.Items.AddRange(items.ToArray());

            if (cmbMusica_Lista.Items.Count > 0)
                cmbMusica_Lista.SelectedIndex = 0;
        }

        // ── Tabla ─────────────────────────────────────────────────────
        private void CargarDatosTabla()
        {
            MostrarDatos1.DataSource = null;
            MostrarDatos1.Rows.Clear();
            MostrarDatos1.Columns.Clear();

            List<Articulo> lista = _controller.CargarDesdeCsv();
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
            if (cols["RutaPortada"] != null)
                cols["RutaPortada"].Visible = false;

            TablaEstilo.Aplicar(MostrarDatos1);

            // Forzar la limpieza de selección
            if (MostrarDatos1.Rows.Count > 0)
            {
                MostrarDatos1.CurrentCell = null;
                MostrarDatos1.ClearSelection();
            }
        }

        protected override void OnShown(EventArgs e)
        {
            base.OnShown(e);
            MostrarDatos1.ClearSelection();
            MostrarDatos1.CurrentCell = null;
        }

        // ── Registrar artículo ────────────────────────────────────────
        private void guna2Button1_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtCodigoArticulo.Text))
            {
                MessageBox.Show("El código es obligatorio.", "Aviso"); return;
            }
            if (string.IsNullOrWhiteSpace(txtTitulo.Text))
            {
                MessageBox.Show("El título es obligatorio.", "Aviso"); return;
            }
            if (CmbTipo.SelectedIndex == -1)
            {
                MessageBox.Show("Debes seleccionar un tipo.", "Aviso"); return;
            }
            if (_controller.CodigoExiste(txtCodigoArticulo.Text))
            {
                MessageBox.Show("Ya existe un artículo con ese código.", "Aviso"); return;
            }

            Articulo nuevo = new Articulo
            {
                Codigo       = txtCodigoArticulo.Text,
                Titulo       = txtTitulo.Text,
                Artistas     = txtArtista.Text,
                TipoArticulo = CmbTipo.Text,
                Cantidad     = (int)numCantidadInicial.Value,
                Precio       = numPrecioArticulo.Value,
                RutaPortada  = _rutaImagenTemporal
            };

            _controller.RegistrarEnCsv(nuevo);
            MessageBox.Show("¡Artículo registrado con éxito!", "Éxito");

            CargarDatosTabla();
            guna2Button2_Click(null, null);
        }

        // ── Limpiar campos ────────────────────────────────────────────
        private void guna2Button2_Click(object sender, EventArgs e)
        {
            txtTitulo.Clear();
            txtArtista.Clear();
            txtCodigoArticulo.Clear();
            CmbTipo.SelectedIndex  = -1;
            numCantidadInicial.Value = 1;
            numPrecioArticulo.Value  = 1000;
            picPrevisualizacion.Image = null;
            _rutaImagenTemporal = "";
        }

        // ── Subir portada ─────────────────────────────────────────────
        private void guna2Button5_Click(object sender, EventArgs e)
        {
            using (OpenFileDialog buscador = new OpenFileDialog())
            {
                buscador.Filter = "PNG Files (*.png)|*.png";
                if (buscador.ShowDialog() == DialogResult.OK)
                {
                    _rutaImagenTemporal = buscador.FileName;
                    picPrevisualizacion.ImageLocation = _rutaImagenTemporal;
                }
            }
        }

        // ── Cerrar ────────────────────────────────────────────────────
        private void guna2Button4_Click(object sender, EventArgs e) => this.Close();

        private void Music_Store_Load(object sender, EventArgs e) { }
    }
}
