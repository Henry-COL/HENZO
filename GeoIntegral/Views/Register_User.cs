using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GeoIntegral.Views
{
    public partial class Register_User : Form
    {
        public Register_User()
        {
            InitializeComponent();
        }

        private void guna2Button2_Click(object sender, EventArgs e)
        {
            Owner.Show();
            this.Close();
        }

        private void guna2Button1_Click(object sender, EventArgs e)
        {
            Owner.Show();
            this.Close();
        }
    }
}
