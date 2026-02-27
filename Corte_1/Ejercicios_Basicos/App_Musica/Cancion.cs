using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Corte_1.Ejercicios_Basicos.App_Musica
{
    public class Cancion : IReproductor
    {
        public string Titulo { get; private set; }
        public string Artista { get; set; }

        public Cancion(string titulo, string artista)
        {
            Titulo = titulo;
            Artista = artista;
        }

        public void Play()
        {
            Console.WriteLine("Reproduciendo cancion: " + Titulo + " de " + Artista);
        }

        public void Stop()
        {
            Console.WriteLine("Pausando cancion: " + Titulo);
        }
    }
}