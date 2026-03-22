using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cumpleaños
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string ruta = "cumpleaños.txt";

            for (int i = 1; i <= 3; i++)
            {
                Console.WriteLine("\n====== Calcular Fecha Cumpleaños ======");
                Console.Write($"Ingrese el nombre del amigo {i}: ");
                string nombre = Console.ReadLine();

                Console.Write("Ingrese su fecha de nacimiento (Día Mes Año): ");
                string fechaNacimientoStr = Console.ReadLine();

                // 1. Convertir la fecha original
                DateTime fechaNacimiento = DateTime.Parse(fechaNacimientoStr);

                // 2. Crear el cumpleaños con el año actual
                DateTime proximoCumple = new DateTime(DateTime.Today.Year, fechaNacimiento.Month, fechaNacimiento.Day);

                // 3. CORRECCIÓN: Si ya pasó este año, sumamos uno para que sea en 2027
                if (proximoCumple < DateTime.Today)
                {
                    proximoCumple = proximoCumple.AddYears(1);
                }

                // 4. AHORA calculamos la resta (siempre será positiva)
                TimeSpan faltan = proximoCumple - DateTime.Today;

                // 5. Mostrar en consola
                Console.WriteLine($"Faltan {faltan.Days} días para el cumpleaños de {nombre}. Nacimiento: {fechaNacimiento:dd/MM/yyyy}");


                string linea = $"Amigo: {nombre}, Nacimiento: {fechaNacimiento:dd/MM/yyyy}, Días para el próximo cumple: {faltan.Days}" + Environment.NewLine;
                File.AppendAllText(ruta, linea);
            }

            Console.Write("\nProceso terminado. Revisa el archivo 'cumpleaños.txt'.");
            Console.ReadKey();
        }
    }
}
