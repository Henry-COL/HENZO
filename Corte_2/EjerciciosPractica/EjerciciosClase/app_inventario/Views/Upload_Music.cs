using app_inventario.Controllers;
using app_inventario.Models;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace app_inventario.Views
{
    public partial class Upload_Music : Form
    {
        private readonly ArticuloController _controller;

        public Upload_Music()
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
            List<EntradaMusica> entradas = _controller.CargarEntradas();
            if (entradas == null || entradas.Count == 0) return;

            foreach (EntradaMusica e in entradas)
            {
                int fila = MostrarDatos1.Rows.Add(
                    e.Fecha, e.Codigo, e.Titulo, e.Cantidad, e.Observacion);

                // Usamos TablaEstilo para no duplicar fuentes
                TablaEstilo.AplicarColorCantidad(
                    MostrarDatos1.Rows[fila].Cells["Cantidad"], esEntrada: true);
            }

            // Un solo método reemplaza los ~20 líneas de estilos repetidos
            TablaEstilo.Aplicar(MostrarDatos1);

            MostrarDatos1.ClearSelection();
            MostrarDatos1.CurrentCell = null;
        }

        // ── Registrar entrada ─────────────────────────────────────────
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

            _controller.ActualizarCantidad(codigo, cantidad);
            _controller.RegistrarEntrada(codigo, titulo, cantidad, observacion);

            MessageBox.Show($"Entrada registrada: +{cantidad} unidades a {titulo}");

            CargarDatosTabla();
            numCantidadInicial.Value = 1;
            txtObservacion.Text = "";
        }

        // ── Cerrar ────────────────────────────────────────────────────
        private void btnClose_Click(object sender, EventArgs e) => this.Close();
    }
}
