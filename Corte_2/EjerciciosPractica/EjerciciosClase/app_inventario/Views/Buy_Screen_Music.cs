using app_inventario.Controllers;
using app_inventario.Models;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace app_inventario.Views
{
    public partial class Buy_Screen_Music : Form
    {
        private readonly ArticuloController _controller;

        public Buy_Screen_Music()
        {
            _controller = new ArticuloController();
            InitializeComponent();
            CargarComboBoxMusica();
            CargarDatosTabla();
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

            MostrarDatos1.Columns.Add("Fecha",       "Fecha");
            MostrarDatos1.Columns.Add("Codigo",      "Código");
            MostrarDatos1.Columns.Add("Titulo",      "Título");
            MostrarDatos1.Columns.Add("Cantidad",    "Cantidad");
            MostrarDatos1.Columns.Add("Observacion", "Observación");

            // El controlador devuelve modelos tipados, no string[]
            List<SalidaMusica> salidas = _controller.CargarSalidas();
            if (salidas == null || salidas.Count == 0) return;

            foreach (SalidaMusica s in salidas)
            {
                int fila = MostrarDatos1.Rows.Add(
                    s.Fecha, s.Codigo, s.Titulo, s.Cantidad, s.Observacion);

                // TablaEstilo maneja la fuente — sin new Font() por cada fila
                TablaEstilo.AplicarColorCantidad(
                    MostrarDatos1.Rows[fila].Cells["Cantidad"], esEntrada: false);
            }

            // Un solo método reemplaza los ~20 líneas de estilos repetidos
            TablaEstilo.Aplicar(MostrarDatos1);

            MostrarDatos1.ClearSelection();
            MostrarDatos1.CurrentCell = null;
        }

        // ── Registrar compra ──────────────────────────────────────────
        private void btnRegistrarEntrada_Click(object sender, EventArgs e)
        {
            if (cmbMusica_Lista.SelectedItem == null)
            {
                MessageBox.Show("Seleccione un artículo.");
                return;
            }

            // Split seguro: maneja títulos con guión (ej. "AC/DC - Back in Black")
            string seleccionado = cmbMusica_Lista.SelectedItem.ToString();
            string[] partes    = seleccionado.Split(new[] { " - " }, 2, StringSplitOptions.None);
            string codigo      = partes[0].Trim();
            string titulo      = partes.Length > 1 ? partes[1].Trim() : "";

            int cantidad       = (int)numCantidadInicial.Value;
            string observacion = txtObservacion.Text.Trim();

            if (cantidad <= 0)
            {
                MessageBox.Show("La cantidad debe ser mayor a 0.");
                return;
            }

            _controller.RestarCantidad(codigo, cantidad);
            _controller.RegistrarSalida(codigo, titulo, cantidad, observacion);

            CargarDatosTabla();

            numCantidadInicial.Value = 1;
            txtObservacion.Text = "";

            MessageBox.Show($"Compra registrada: -{cantidad} unidades de {titulo}");
        }

        // ── Cerrar ────────────────────────────────────────────────────
        private void guna2Button4_Click(object sender, EventArgs e) => this.Close();
    }
}
