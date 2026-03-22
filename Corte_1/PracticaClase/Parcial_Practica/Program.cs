using Parcial_Practica.GlobalShip.Enum;
using Parcial_Practica.GlobalShip.Modelo;
using System;
using System.Collections.Generic;
using System.IO;

namespace Parcial_Practica
{
    internal class Program
    {
        static string ruta = "envios.csv";

        static void Main(string[] args)
        {
            string op = "";
            while (op != "0")
            {
                Console.Clear();
                Console.WriteLine("===== GLOBALSHIP ======");
                Console.WriteLine("1. Crear Envío");
                Console.WriteLine("2. Reporte de Carga");
                Console.WriteLine("3. Buscar por Guía");
                Console.WriteLine("0. Salir");
                Console.Write("Opción: ");
                op = Console.ReadLine();

                if (op == "1") Crear();
                if (op == "2") Reporte();
                if (op == "3") Buscar();

                if (op != "0") { Console.WriteLine("\nPresione una tecla..."); Console.ReadKey(); }
            }
        }

        static void Crear()
        {
            Console.Write("Guía: ");
            int g = int.Parse(Console.ReadLine());
            Console.Write("Destinatario: ");
            string d = Console.ReadLine();
            Console.Write("Peso: ");
            double p = double.Parse(Console.ReadLine());
            Console.Write("Tipo (Nacional/Internacional): ");
            Tipo t = (Tipo)Enum.Parse(typeof(Tipo), Console.ReadLine(), true);

            Paquete nuevo = new Paquete(p, g, d, t);
            File.AppendAllLines(ruta, new List<string> { nuevo.ToCSV() });
            Console.WriteLine("Guardado con éxito.");
           
        }

        static void Reporte()
        {
            if (!File.Exists(ruta)) return;
            double total = 0;
            foreach (string line in File.ReadAllLines(ruta))
            {
                string[] datos = line.Split(';');
                total += double.Parse(datos[2]);
            }
            Console.WriteLine($"Peso total acumulado: {total} kg");
        }
        static void Buscar()
        {
            Console.Write("Guía a buscar: ");
            string buscado = Console.ReadLine();
            if (!File.Exists(ruta)) return;

            foreach (string line in File.ReadAllLines(ruta))
            {
                string[] datos = line.Split(';');
                if (datos[0] == buscado)
                {
                    Console.WriteLine("Datos: " + line);
                    return;
                }
            }
            Console.WriteLine("Guía no encontrada.");
        }
    }
}