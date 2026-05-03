using System.Drawing;
using System.Windows.Forms;

namespace app_inventario.Controllers
{
    public static class TablaEstilo
    {
        private static readonly Color Fondo = Color.FromArgb(15, 52, 67);
        private static readonly Color FondoAlt = Color.FromArgb(5, 32, 41);
        private static readonly Color Seleccion = Color.FromArgb(0, 120, 160);
        private static readonly Font Fuente = new Font("Segoe UI", 9.5f);
        private static readonly Font FuenteEncabezado = new Font("Segoe UI", 10f, FontStyle.Bold);

        public static void Aplicar(DataGridView tabla)
        {
            tabla.EnableHeadersVisualStyles = false;
            tabla.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            tabla.ColumnHeadersHeight = 35;
            tabla.AllowUserToAddRows = false;
            tabla.ReadOnly = true;

            // Encabezado
            tabla.ColumnHeadersDefaultCellStyle.BackColor = FondoAlt;
            tabla.ColumnHeadersDefaultCellStyle.ForeColor = Color.White;
            tabla.ColumnHeadersDefaultCellStyle.Font = FuenteEncabezado;

            // Celdas
            tabla.DefaultCellStyle.BackColor = Fondo;
            tabla.DefaultCellStyle.ForeColor = Color.White;
            tabla.DefaultCellStyle.Font = Fuente;
            tabla.DefaultCellStyle.SelectionBackColor = Seleccion;
            tabla.DefaultCellStyle.SelectionForeColor = Color.White;

            // Filas alternas
            tabla.AlternatingRowsDefaultCellStyle.BackColor = FondoAlt;
            tabla.AlternatingRowsDefaultCellStyle.ForeColor = Color.White;
            tabla.AlternatingRowsDefaultCellStyle.Font = Fuente;
        }

        public static void AplicarColorCantidad(DataGridViewCell celda, bool esEntrada)
        {
            celda.Style.ForeColor = esEntrada ? Color.LimeGreen : Color.Red;
            celda.Style.Font = new Font("Segoe UI", 9.5f, FontStyle.Bold);
        }

        public static void AplicarFilasAlternas(DataGridView tabla)
        {
            for (int i = 0; i < tabla.Rows.Count; i++)
                tabla.Rows[i].DefaultCellStyle.BackColor = i % 2 == 0 ? Fondo : FondoAlt;
        }
    }
}