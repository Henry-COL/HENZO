using app_inventario.Controllers;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace app_inventario.Views
{
    public partial class Buy_Screen_Music : Form
    {
        private ArticuloController _controller;

        public Buy_Screen_Music()
        {
            _controller = new ArticuloController();
            InitializeComponent();
            CargarComboBoxMusica();
            CargarDatosTabla();
        }

        private void CargarComboBoxMusica()
        {
            var items = _controller.ObtenerMusicaParaComboBox();
            cmbMusica_Lista.Items.Clear();
            cmbMusica_Lista.Items.AddRange(items.ToArray());

            if (cmbMusica_Lista.Items.Count > 0)
                cmbMusica_Lista.SelectedIndex = 0;
        }

        private void CargarDatosTabla()
        {
            MostrarDatos1.DataSource = null;
            MostrarDatos1.Rows.Clear();
            MostrarDatos1.Columns.Clear();
            MostrarDatos1.AllowUserToAddRows = false;

            MostrarDatos1.Columns.Add("Fecha", "Fecha");
            MostrarDatos1.Columns.Add("Codigo", "Código");
            MostrarDatos1.Columns.Add("Titulo", "Título");
            MostrarDatos1.Columns.Add("Cantidad", "Cantidad");
            MostrarDatos1.Columns.Add("Observacion", "Observación");

            List<string[]> salidas = _controller.CargarSalidas();
            if (salidas == null || salidas.Count == 0) return;

            foreach (string[] datos in salidas)
            {
                if (datos.Length < 5) continue;
                int fila = MostrarDatos1.Rows.Add(datos[0], datos[1], datos[2], datos[3], datos[4]);
                MostrarDatos1.Rows[fila].Cells["Cantidad"].Style.ForeColor = Color.Red;
                MostrarDatos1.Rows[fila].Cells["Cantidad"].Style.Font = new Font("Segoe UI", 9.5f, FontStyle.Bold);
            }

            Color fondo = Color.FromArgb(15, 52, 67);
            Color fondoAlt = Color.FromArgb(5, 32, 41);
            Font fuente = new Font("Segoe UI", 9.5f);

            MostrarDatos1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            MostrarDatos1.ColumnHeadersHeight = 35;
            MostrarDatos1.EnableHeadersVisualStyles = false;

            MostrarDatos1.ColumnHeadersDefaultCellStyle.BackColor = fondoAlt;
            MostrarDatos1.ColumnHeadersDefaultCellStyle.ForeColor = Color.White;
            MostrarDatos1.ColumnHeadersDefaultCellStyle.Font = new Font("Segoe UI", 10f, FontStyle.Bold);

            MostrarDatos1.DefaultCellStyle.BackColor = fondo;
            MostrarDatos1.DefaultCellStyle.ForeColor = Color.White;
            MostrarDatos1.DefaultCellStyle.Font = fuente;
            MostrarDatos1.DefaultCellStyle.SelectionBackColor = fondo;
            MostrarDatos1.DefaultCellStyle.SelectionForeColor = Color.White;

            MostrarDatos1.AlternatingRowsDefaultCellStyle.BackColor = fondoAlt;
            MostrarDatos1.AlternatingRowsDefaultCellStyle.ForeColor = Color.White;
            MostrarDatos1.AlternatingRowsDefaultCellStyle.Font = fuente;

            for (int i = 0; i < MostrarDatos1.Rows.Count; i++)
                MostrarDatos1.Rows[i].DefaultCellStyle.BackColor = i % 2 == 0 ? fondo : fondoAlt;

            MostrarDatos1.ReadOnly = true;
            MostrarDatos1.ClearSelection();
            MostrarDatos1.CurrentCell = null;
        }

        private void btnRegistrarEntrada_Click(object sender, EventArgs e)
        {
            if (cmbMusica_Lista.SelectedItem == null)
            {
                MessageBox.Show("Seleccione un artículo.");
                return;
            }

            string seleccionado = cmbMusica_Lista.SelectedItem.ToString();
            string codigo = seleccionado.Split('-')[0].Trim();
            string titulo = seleccionado.Split('-')[1].Trim();
            int cantidad = (int)numCantidadInicial.Value;
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

        private void guna2Button4_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}