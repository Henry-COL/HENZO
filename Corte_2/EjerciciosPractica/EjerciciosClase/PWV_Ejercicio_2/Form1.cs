using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PWV_Ejercicio_2
{
    public partial class Form1 : Form
    {
        public partial class Form1 : Form
        {
            public Form1()
            {
                InitializeComponent();
            }

            private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
            {

            }

            private void chkFechaVenci_CheckedChanged(object sender, EventArgs e)
            {

            }

            private void btnValidar_Click(object sender, EventArgs e)
            {
                bool validatecode = false;
                bool validatestock = false;
                bool validaterb = false;
                bool validatenameproduct = false;
                bool validatecategoria = false;
                bool validated = false;

                if (txtCodigo.Text.StartsWith("PROD-"))
                {
                    validatecode = true;
                }

                if (numStockInicial.Value < numStockMinimo.Value)
                {

                }
                else
                {
                    validatestock = true;
                }




                if (rbGeneral.Checked)
                {
                    validaterb = true;
                }

                if (rbReducido.Checked)
                {
                    validaterb = true;
                }

                if (rbExento.Checked)
                {
                    validaterb = true;
                }


                if (txtNombreProducto.Text == "")
                {

                }
                else
                {
                    validatenameproduct = true;
                }


                if (cmbCategoria.SelectedIndex == -1)
                {

                }
                else
                {
                    validatecategoria = true;
                }



                if (validatestock == true && validaterb == true && validatenameproduct == true && validatecode == true && validatecategoria == true)
                {
                    validated = true;
                }

                if (validated == true)
                {
                    lblValidar.Visible = true;
                    lblValidar.Text = "VALIDADO AMOR";
                }
                else
                {
                    lblValidar.Visible = false;
                }
            }

            private void chkEsPerecedero_CheckedChanged(object sender, EventArgs e)
            {
                if (chkEsPerecedero.Checked)
                {
                    dtpFechaVencimiento.Enabled = true;
                }
            }
        }
    }
}
