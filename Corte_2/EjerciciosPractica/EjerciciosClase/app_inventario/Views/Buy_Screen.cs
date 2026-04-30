using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace app_inventario.Views
{
    public partial class Buy_Screen : Form
    {
        public Buy_Screen()
        {
            InitializeComponent();
        }

        private void btnBuy_Cancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
