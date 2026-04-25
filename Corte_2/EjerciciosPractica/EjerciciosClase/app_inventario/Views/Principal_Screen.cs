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
        }

        private void guna2Button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void guna2Button2_Click(object sender, EventArgs e)
        {
            pag1.Visible = true;
                pag2.Visible = false;
                pag3.Visible = false;
                pag4.Visible = false; pag5.Visible = false;
        }

        private void guna2Panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void guna2Button3_Click(object sender, EventArgs e)
        {
            pag2.Visible = true;
            pag1.Visible = false; pag3.Visible = false;
            pag4.Visible = false; pag5.Visible = false;

            Music_Store music_Store = new Music_Store();
            music_Store.Show();
        }

        private void guna2Button4_Click(object sender, EventArgs e)
        {
            pag3.Visible = true;
            pag1.Visible = false; pag2.Visible = false;
            pag4.Visible = false; pag5.Visible = false;
        }

        private void guna2Button5_Click(object sender, EventArgs e)
        {
            pag4.Visible = true;
            pag1.Visible = false; pag2.Visible = false;
            pag3.Visible = false; pag5.Visible = false;
        }

        private void guna2Button6_Click(object sender, EventArgs e)
        {
            pag5.Visible = true;
            pag1.Visible = false; pag2.Visible = false;
            pag3.Visible = false; pag4.Visible = false;
        }

        private void New_Add_newBuy_Click(object sender, EventArgs e)
        {

        }
    }
}
