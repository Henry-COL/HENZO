using app_inventario.Controller;
using app_inventario.Controllers;
using app_inventario.Models;
using app_inventario.Views;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace app_inventario
{
    public partial class Principal_Screen : Form
    {
        private readonly UsuarioController    _controller;
        private readonly ArticuloController   _articuloController;
        private FileSystemWatcher             _watcher;

        public Principal_Screen()
        {
            InitializeComponent();
            _controller         = new UsuarioController(new UsuarioModel { Saldo = 180000 });
            _articuloController = new ArticuloController();
            _articuloController.InicializarArchivos();
            ActualizarSaldoLabel();
            CargarTarjetas();
            IniciarWatcher();
        }

        // ── Watcher ───────────────────────────────────────────────────
        private void IniciarWatcher()
        {
            string raiz    = Path.GetFullPath(Path.Combine(Application.StartupPath, "..", ".."));
            string carpeta = Path.Combine(raiz, "DataBase");

            _watcher = new FileSystemWatcher(carpeta, "Music.csv")
            {
                NotifyFilter      = NotifyFilters.LastWrite,
                EnableRaisingEvents = true
            };
            _watcher.Changed += OnArchivoModificado;
        }

        private void OnArchivoModificado(object sender, FileSystemEventArgs e)
        {
            if (this.InvokeRequired)
                this.Invoke((Action)(() => CargarTarjetas()));
            else
                CargarTarjetas();
        }

        // Liberar watcher al cerrar el formulario
        private void Principal_Screen_FormClosing(object sender, FormClosingEventArgs e)
        {
            _watcher?.Dispose();
        }

        // ── Saldo ─────────────────────────────────────────────────────
        private void ActualizarSaldoLabel()
        {
            // ObtenerSaldo() ya devuelve long — cuando migres a decimal, cambia aquí también
            lblSaldo_User.Text = _controller.ObtenerSaldo()
                .ToString("N0").Replace(",", ".");
        }

        private async void AnimarSaldoInsuficiente()
        {
            lblSaldo_User.ForeColor = Color.Red;
            await Task.Delay(600);
            lblSaldo_User.ForeColor = Color.White;
            MessageBox.Show("Saldo insuficiente.", "Sin saldo",
                MessageBoxButtons.OK, MessageBoxIcon.Warning);
        }

        // ── Tarjetas ──────────────────────────────────────────────────
        private void CargarTarjetas()
        {
            CargarTarjetasPopulares(_articuloController.ObtenerMasPopulares());
            CargarTarjetasRecientes(_articuloController.ObtenerRecienAnadidos());
        }

        private void CargarTarjetasPopulares(List<Articulo> lista)
        {
            PictureBox[] fotos   = { Most_Popular_1, Most_Popular_3, Most_Popular_2 };
            Label[]      artistas = { lblArtista_Más_Popular, lblArtista_Medio_Popular, lblArtista_Popular_Minimo };
            Label[]      precios  = { lblPrecio_Mas_Popular, lblPrecio_Medio_Popular, lblPrecio_Minimo_Popular };
            Label[]      stocks   = { lblStockPopularMax, lblStockPopularMedio, lblStockPopularMinimo };
            Control[]    botones  = { Most_Popular_buy1, Most_Popular_buy3, Most_Popular_buy2 };

            for (int i = 0; i < fotos.Length; i++)
            {
                if (i >= lista.Count)
                {
                    fotos[i].Image    = null;
                    artistas[i].Text  = "@Artista";
                    precios[i].Text   = "0";
                    stocks[i].Text    = "0";
                    stocks[i].ForeColor = Color.Red;
                    botones[i].Tag    = null;
                    botones[i].Enabled = false;
                    continue;
                }

                Articulo a = lista[i];
                fotos[i].Image      = CargarImagenSegura(a.RutaPortada);
                artistas[i].Text    = $"@{a.Artistas}";
                precios[i].Text     = $"{a.Precio:N0}".Replace(",", ".");
                stocks[i].Text      = $"{a.Cantidad}";
                stocks[i].ForeColor = ObtenerColorStock(a.Cantidad);
                botones[i].Tag      = a;
                botones[i].Enabled  = true;
            }
        }

        private void CargarTarjetasRecientes(List<Articulo> lista)
        {
            PictureBox[] fotos    = { New_Add_new, New_Add_last, New_Add_half };
            Label[]      artistas = { New_Add_newArt, lblArtista_nuevo_medio, lblArtista_añadido_viejo };
            Label[]      precios  = { lblPrecio_RecienAñadido, lblPrecio_Añadido_Medio, lblPrecio_Añadido_Viejo };
            Label[]      stocks   = { lblStockNuevo, lblStockNuevoMedio, lblStockNuevoViejo };
            Control[]    botones  = { New_Add_newBuy, New_Add_lastBuy, New_Add_halfBuy };

            for (int i = 0; i < fotos.Length; i++)
            {
                if (i >= lista.Count)
                {
                    fotos[i].Image    = null;
                    artistas[i].Text  = "@Artista";
                    precios[i].Text   = "0";
                    stocks[i].Text    = "0";
                    stocks[i].ForeColor = Color.Red;
                    botones[i].Tag    = null;
                    botones[i].Enabled = false;
                    continue;
                }

                Articulo a = lista[i];
                fotos[i].Image      = CargarImagenSegura(a.RutaPortada);
                artistas[i].Text    = $"@{a.Artistas}";
                precios[i].Text     = $"{a.Precio:N0}".Replace(",", ".");
                stocks[i].Text      = $"{a.Cantidad}";
                stocks[i].ForeColor = ObtenerColorStock(a.Cantidad);
                botones[i].Tag      = a;
                botones[i].Enabled  = true;
            }
        }

        // Carga la imagen sin bloquear el archivo en disco
        private Image CargarImagenSegura(string ruta)
        {
            if (!File.Exists(ruta)) return null;
            using (FileStream fs = new FileStream(ruta, FileMode.Open, FileAccess.Read))
                return Image.FromStream(fs);
        }

        private Color ObtenerColorStock(int cantidad)
        {
            if (cantidad <= 5)  return Color.Red;
            if (cantidad < 15)  return Color.Orange;
            if (cantidad <= 20) return Color.Yellow;
            return Color.LimeGreen;
        }

        // ── Lógica de compra centralizada ─────────────────────────────
        // Evita repetir el mismo bloque if/else en cada botón
        private void ProcesarCompraDesdeBoton(Control boton)
        {
            if (!(boton.Tag is Articulo a)) return;

            // Precio es decimal en el modelo; lo casteamos a long para el
            // controlador actual. Cuando migres UsuarioController a decimal,
            // cambia esta línea a: _controller.ProcesarCompra(a.Precio)
            if (_controller.ProcesarCompra((long)a.Precio))
            {
                ActualizarSaldoLabel();
                CargarTarjetas();
            }
            else
            {
                AnimarSaldoInsuficiente();
            }
        }

        // ── Botones populares ─────────────────────────────────────────
        private void Most_Popular_buy1_Click(object sender, EventArgs e) =>
            ProcesarCompraDesdeBoton(Most_Popular_buy1);

        private void Most_Popular_buy2_Click(object sender, EventArgs e) =>
            ProcesarCompraDesdeBoton(Most_Popular_buy2);

        private void Most_Popular_buy3_Click(object sender, EventArgs e) =>
            ProcesarCompraDesdeBoton(Most_Popular_buy3);

        // ── Botones recientes ─────────────────────────────────────────
        private void New_Add_newBuy_Click(object sender, EventArgs e) =>
            ProcesarCompraDesdeBoton(New_Add_newBuy);

        private void New_Add_lastBuy_Click(object sender, EventArgs e) =>
            ProcesarCompraDesdeBoton(New_Add_lastBuy);

        private void New_Add_halfBuy_Click(object sender, EventArgs e) =>
            ProcesarCompraDesdeBoton(New_Add_halfBuy);

        // ── Navegación ────────────────────────────────────────────────
        private void btnMusicStore_Click(object sender, EventArgs e)  => new Music_Store().Show();
        private void btnUpload_Music_Click(object sender, EventArgs e) => new Upload_Music().Show();
        private void btnBuy_Music_Click(object sender, EventArgs e)    => new Buy_Screen_Music().Show();
        private void btnCerrar_Click(object sender, EventArgs e)       => this.Close();

        // ── Eventos vacíos (diseñador) ────────────────────────────────
        private void Precio_RecienAñadido_Click(object sender, EventArgs e) { }
        private void lblPrecio_Añadido_Medio_Click(object sender, EventArgs e) { }
        private void label23_Click(object sender, EventArgs e) { }
        private void btnHistory_Click(object sender, EventArgs e) { }
        private void Principal_Screen_Load(object sender, EventArgs e) { }
        private void guna2Panel4_Paint(object sender, PaintEventArgs e) { }
        private void Most_Popular_1_Click(object sender, EventArgs e) { }
        private void Most_Popular_2_Click(object sender, EventArgs e) { }
        private void Most_Popular_3_Click(object sender, EventArgs e) { }
        private void New_Add_half_Click(object sender, EventArgs e) { }
    }
}
