using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Corte_1.Ejercicios_Basicos.Sitema_Biblioteca
{
    public class Libro
    {
        public string titulo;
        public bool disponible;

        public Libro(string nombre)
        {
            titulo = nombre;
            disponible = true;
        }

        public void Prestar()
        {
            if (disponible)
            {
                disponible = false;
                Console.WriteLine("Libro prestado: " + titulo);
            }
            else
            {
                Console.WriteLine("No disponible: " + titulo);
            }
        }
    }
}
