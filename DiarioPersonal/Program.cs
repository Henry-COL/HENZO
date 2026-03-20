using System;
using System.IO;
using System.Linq;

namespace DiarioPersonal
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Nombre: ");
            var usuario = Console.ReadLine();
            if (string.IsNullOrWhiteSpace(usuario)) usuario = "Usuario";

            var ruta = Path.Combine(Environment.CurrentDirectory, "diario.txt");

            if (File.Exists(ruta))
            {
                var lineas = File.ReadAllLines(ruta);
                Console.WriteLine("\nÚltimas 3 entradas:");
                foreach (var l in lineas.Skip(Math.Max(0, lineas.Length - 3)))
                    Console.WriteLine(l);
            }
            else
            {
                Console.WriteLine("\nNo hay entradas.");
            }

            Console.Write("\nEscribe tu entrada: ");
            var mensaje = Console.ReadLine();
            if (string.IsNullOrWhiteSpace(mensaje))
            {
                Console.WriteLine("Nada que guardar.");
                return;
            }

            var linea = $"[{DateTime.Now:yyyy-MM-dd HH:mm:ss}] - {usuario}: {mensaje}{Environment.NewLine}";
            File.AppendAllText(ruta, linea);
            Console.WriteLine("Entrada guardada.");
        }
    }
}
