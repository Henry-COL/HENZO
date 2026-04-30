using app_inventario.Controllers;
using app_inventario.Views;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace app_inventario
{
    public partial class Principal_Screen : Form
    {
        public Principal_Screen()
        {
            InitializeComponent();
            ArticuloController controlador = new ArticuloController();
            controlador.InicializarArchivos();
        }

        private void btnHome_Click(object sender, EventArgs e)
        {
        }

        private void btnMusicStore_Click(object sender, EventArgs e)
        {
            Music_Store music_Store = new Music_Store();
            music_Store.Show();
        }

        private void btnUpload_Music_Click(object sender, EventArgs e)
        {
        }

        private void btnBuy_Music_Click(object sender, EventArgs e)
        {
        }

        private void btnHistory_Click(object sender, EventArgs e)
        {
        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void New_Add_newBuy_Click(object sender, EventArgs e)
        {
            Buy_Screen buy_Screen = new Buy_Screen();
            buy_Screen.Show();
        }

        private void Most_Popular_buy1_Click(object sender, EventArgs e)
        {
            lblSaldo_User.Text = "5000";
        }
    }
}
