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
    public partial class Error_MSG : Form
    {
        public Error_MSG()
        {
            InitializeComponent();
        }

        private void btnOk_Error_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
