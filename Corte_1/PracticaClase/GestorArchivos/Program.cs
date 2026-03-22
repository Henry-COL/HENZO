using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GestorArchivos
{
    internal class Program
    {
        static void Main(string[] args)
        {
            for (int i = 1; i <= 3; i ++)
            {
                Console.WriteLine("\nUsuario " + i);
                Console.WriteLine("Ingrese su nombre: ");
                string nombre = Console.ReadLine();
                Console.WriteLine("Ingrese su fecha de nacimiento: ");
                string FechaNacimmiento = Console.ReadLine();


                DateTime FechaUsuario = DateTime.Parse(FechaNacimmiento);

                // Calcular la edad
                TimeSpan DiasParaCumpleaños = (FechaUsuario - DateTime.Now);

                string data = $"El amigo: {nombre} cummple el {FechaUsuario} le hacen falta {DiasParaCumpleaños.Days} dias para su cumpleaños.";
                string ruta = "cumpleaños.txt";

                File.AppendAllText(ruta, data);
            }

        }
    }
}
