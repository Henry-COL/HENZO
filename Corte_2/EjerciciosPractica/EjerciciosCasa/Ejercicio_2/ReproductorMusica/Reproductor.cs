using System;
using System.Windows.Forms;
using WMPLib;

namespace ReproductorMusica
{
    public partial class Reproductor : Form
    {
        WindowsMediaPlayer player = new WindowsMediaPlayer();

        public Reproductor()
        {
            InitializeComponent();
            // Asociamos el evento Tick del timer
            timer1.Tick += new EventHandler(timer1_Tick);
        }

        private void Reproducir_Click(object sender, EventArgs e)
        {
            try
            {
                string rutaArchivo = @"C:\Users\Henry Quintero\Documents\GitHub\HENZO\Corte_2\EjerciciosPractica\EjerciciosCasa\Ejercicio_2\ReproductorMusica\Images\Aria Vega, Ryan Castro -  CHÉVERE.mp3";
                Titulo_Musica.Text = System.IO.Path.GetFileNameWithoutExtension(rutaArchivo);
                player.URL = rutaArchivo;
                player.controls.play();

                // Iniciamos el timer para que empiece a contar
                timer1.Start();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (player.currentMedia != null)
            {
                // 1. Actualizar Labels de tiempo
                TiempoTranscurrido.Text = player.controls.currentPositionString;
                TiempoTotal.Text = player.currentMedia.durationString;

                // 2. Configurar y actualizar la Barra de Progreso
                // Importante: El 'Duration' puede tardar un momento en cargar, 
                // por eso verificamos que sea mayor a 0.
                if (player.currentMedia.duration > 0)
                {
                    // Establecemos el máximo de la barra como la duración total en segundos
                    BarraProgreso.Maximum = (int)player.currentMedia.duration;

                    // Establecemos el valor actual como la posición actual en segundos
                    BarraProgreso.Value = (int)player.controls.currentPosition;
                }
            }
        }
    }
}