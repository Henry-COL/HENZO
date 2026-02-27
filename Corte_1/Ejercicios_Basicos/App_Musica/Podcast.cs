using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Corte_1.Ejercicios_Basicos.App_Musica
{
    public class Podcast : IReproductor
    {
        public string Titulo { get; private set; }
        public string Host { get; set; }

        public Podcast(string nombre, string host)
        {
            Titulo = nombre;
            Host = host;
        }

        public void Play()
        {
            Console.WriteLine("Escuchando Podcast: " + Titulo + " con " + Host);
        }

        public void Stop()
        {
            Console.WriteLine("Deteniendo Podcast: " + Titulo);
        }
    }
}
