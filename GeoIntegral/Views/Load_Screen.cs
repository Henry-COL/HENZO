using System;
using System.Drawing;
using System.Windows.Forms;

namespace GeoIntegral.Views
{
    public partial class Load_Screen : Form
    {
        private double _pasoOpacidad;
        private double _pasoProgreso;
        private double _progresoActual = 0;

        private const double SegundosOpacidad = 1.5;
        private const double SegundosBarra = 5.0;
        private const int IntervaloTimer = 15;

        public Load_Screen()
        {
            InitializeComponent();
            ConfigurarComponentes();
        }

        private void ConfigurarComponentes()
        {

            if (this.DesignMode) return;

            Logo_App.BackColor = Color.Transparent;

            Barra_Carga.Minimum = 0;
            Barra_Carga.Maximum = 100;
            Barra_Carga.Value = 0;

            double ticksOpacidad = (SegundosOpacidad * 1000.0) / IntervaloTimer;
            _pasoOpacidad = 1.0 / ticksOpacidad;

            double ticksBarra = (SegundosBarra * 1000.0) / IntervaloTimer;
            _pasoProgreso = 100.0 / ticksBarra;

            tmrFadeIn.Interval = IntervaloTimer;
        }

        private void Load_Screen_Load(object sender, EventArgs e)
        {
            this.DoubleBuffered = true;
            this.Opacity = 0;
            tmrFadeIn.Start();
        }

        private void tmrFadeIn_Tick(object sender, EventArgs e)
        {
            if (this.Opacity < 1.0)
            {
                this.Opacity += _pasoOpacidad;
            }

            if (_progresoActual < 100)
            {
                _progresoActual += _pasoProgreso;
                Barra_Carga.Value = (int)Math.Min(_progresoActual, 100);
            }



            if (this.Opacity >= 1.0 && _progresoActual >= 100)
            {
                tmrFadeIn.Stop();
                this.Opacity = 1.0;
                Barra_Carga.Value = 100;
                this.Close();

            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}