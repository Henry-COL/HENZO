using app_inventario.Controllers;
using app_inventario.Models;
using Guna.UI2.AnimatorNS;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace app_inventario.Views
{
    public partial class Upload_Music : Form
    {
        private ArticuloController _controller;
        public Upload_Music()
        {
            _controller = new ArticuloController();
            InitializeComponent();
            CargarComboBoxMusica();
            CargarDatosTabla();
        }

        private void CargarComboBoxMusica()
        {
            var items = _controller.ObtenerMusicaParaComboBox();
            cmbMusica_Lista.Items.Clear();                    // ← Tu ComboBox
            cmbMusica_Lista.Items.AddRange(items.ToArray());

            if (cmbMusica_Lista.Items.Count > 0)
                cmbMusica_Lista.SelectedIndex = 0;
        }


        private string ObtenerRuta()
        {
            string raiz = Path.GetFullPath(Path.Combine(Application.StartupPath, "..", ".."));
            return Path.Combine(raiz, "DataBase", "Music.csv");
        }

        public List<Articulo> CargarDesdeCsv()
        {
            List<Articulo> lista = new List<Articulo>();
            string ruta = ObtenerRuta();

            if (!File.Exists(ruta)) { return lista; }

            string[] lineas = File.ReadAllLines(ruta, Encoding.UTF8);

            for (int i = 1; i < lineas.Length; i++)
            {
                if (string.IsNullOrWhiteSpace(lineas[i])) continue;

                string[] datos = lineas[i].Split(';');
                if (datos.Length < 7) continue;

                lista.Add(new Articulo
                {
                    Codigo = datos[0],
                    Titulo = datos[1],
                    Artistas = datos[2],
                    TipoArticulo = datos[3],
                    RutaPortada = datos[4],
                    Cantidad = int.Parse(datos[5]),
                    Precio = decimal.Parse(datos[6])
                });
            }

            return lista;
        }

        private void CargarDatosTabla()
        {
            MostrarDatos1.DataSource = null;
            MostrarDatos1.Rows.Clear();
            MostrarDatos1.Columns.Clear();
            MostrarDatos1.AllowUserToAddRows = false; // ✅ Elimina la fila vacía

            MostrarDatos1.Columns.Add("Fecha", "Fecha");
            MostrarDatos1.Columns.Add("Codigo", "Código");
            MostrarDatos1.Columns.Add("Titulo", "Título");
            MostrarDatos1.Columns.Add("Cantidad", "Cantidad");
            MostrarDatos1.Columns.Add("Observacion", "Observación");

            List<string[]> entradas = _controller.CargarEntradas();
            if (entradas == null || entradas.Count == 0) return;

            foreach (string[] datos in entradas)
            {
                if (datos.Length < 5) continue;
                int fila = MostrarDatos1.Rows.Add(datos[0], datos[1], datos[2], datos[3], datos[4]);
                MostrarDatos1.Rows[fila].Cells["Cantidad"].Style.ForeColor = Color.LimeGreen;
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

            // Extraemos código y título del ComboBox "1234 - El Hexxo"
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

            _controller.ActualizarCantidad(codigo, cantidad);
            _controller.RegistrarEntrada(codigo, titulo, cantidad, observacion);

            MessageBox.Show($"Entrada registrada: +{cantidad} unidades a {titulo}");

            // Refrescar tabla y limpiar campos
            CargarDatosTabla();
            numCantidadInicial.Value = 1;
            txtObservacion.Text = "";
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close(); 
        }
    }
}
