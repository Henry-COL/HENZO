using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Corte_1.Ejercicios_Basicos.App_Musica
{
    // Añadimos ": IReproductor" para implementar la interfaz
    public class Podcast : IReproductor
    {
        public string NombreEpisodio;
        public string Host;

        public Podcast(string nombre, string host)
        {
            NombreEpisodio = nombre;
            Host = host;
        }

        public void Play()
        {
            Console.WriteLine("Escuchando Podcast: " + NombreEpisodio + " con " + Host);
        }

        public void Stop()
        {
            Console.WriteLine("Deteniendo Podcast: " + NombreEpisodio);
        }
    }
}
