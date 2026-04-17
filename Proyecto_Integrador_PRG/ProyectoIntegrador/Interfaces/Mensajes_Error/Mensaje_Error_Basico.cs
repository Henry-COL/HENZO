using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProyectoIntegrador.Interfaces.Mensajes_Error
{
    public partial class Mensaje_Error_Basico : Form
    {
        public Mensaje_Error_Basico(string mensaje)
        {
            InitializeComponent();
            lblMensaje_Error_Basico.Text = mensaje;
        }

        private void Mensaje_Error_Basico_Load(object sender, EventArgs e)
        {

            RedondearForm(30);

        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        //Redondear Bordes
        private void RedondearForm(int radio)
        {
            GraphicsPath gp = new GraphicsPath();
            gp.AddArc(0, 0, radio, radio, 180, 90);
            gp.AddArc(this.Width - radio, 0, radio, radio, 270, 90);
            gp.AddArc(this.Width - radio, this.Height - radio, radio, radio, 0, 90);
            gp.AddArc(0, this.Height - radio, radio, radio, 90, 90);
            gp.CloseAllFigures();

            this.Region = new Region(gp);
        }
    }
}
