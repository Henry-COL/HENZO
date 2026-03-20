using Parcial_Practica2.Healt_Tech.Enum;
using Parcial_Practica2.Healt_Tech.modelo;
using System;
using System.Collections.Generic;
using System.IO;

namespace Parcial_Practica2
{
    internal class Program
    {
        static string ruta = "Citas.csv";

        static void Main(string[] args)
        {
            int opcion = -1;
            // Agregamos un while para que el programa no se cierre tras una acción
            while (opcion != 0)
            {
                Console.WriteLine("\n===== Sistema de Gestión de Citas =====");
                Console.WriteLine("1. Agendar una cita médica");
                Console.WriteLine("2. Ver factura (Ver todas)");
                Console.WriteLine("3. Cambiar Especialidad");
                Console.WriteLine("0. Salir");
                Console.Write("Seleccione una opción: ");

                if (!int.TryParse(Console.ReadLine(), out opcion)) continue;

                switch (opcion)
                {
                    case 1: AgendarCita(); break;
                    case 2: VerFactura(); break;
                    case 3: CambiarEspecialidad(); break;
                    case 0: Console.WriteLine("¡Hasta luego!"); break;
                    default: Console.WriteLine("Opción no válida."); break;
                }
            }
        }

        static void AgendarCita()
        {
            Console.WriteLine("\n===== Agendar una cita médica =====");
            Console.Write("Nombre del paciente: ");
            string nombre = Console.ReadLine();

            Console.Write("Especialidad (Pediatria, General ó Odontologia): ");
            Especialidad esp = (Especialidad)Enum.Parse(typeof(Especialidad), Console.ReadLine(), true);

            Console.Write("Costo base: ");
            double costo = double.Parse(Console.ReadLine());

            // Simulando tu clase CitaMedica
            string nuevaLinea = $"{nombre},{esp},{costo}";
            File.AppendAllLines(ruta, new List<string> { nuevaLinea });

            Console.WriteLine("Cita agendada exitosamente.");
        }

        static void VerFactura()
        {
            Console.WriteLine("\n===== Registros en CSV =====");
            if (File.Exists(ruta))
            {
                foreach (var x in File.ReadAllLines(ruta)) Console.WriteLine(x);
            }
            else { Console.WriteLine("El archivo no existe aún."); }
        }

        static void CambiarEspecialidad()
        {
            Console.WriteLine("\n===== Cambiar Especialidad =====");
            Console.Write("Ingrese el nombre del paciente: ");
            string nombrePaciente = Console.ReadLine();

            Console.Write("Ingrese la nueva especialidad: ");
            Especialidad nuevaEsp = (Especialidad)Enum.Parse(typeof(Especialidad), Console.ReadLine(), true);

            if (!File.Exists(ruta)) return;

            string[] lineas = File.ReadAllLines(ruta);
            bool encontrado = false;

            for (int i = 0; i < lineas.Length; i++)
            {
                string[] datos = lineas[i].Split(',');

                // Usamos ToUpper() para que no importe si escriben "juan" o "JUAN"
                if (datos[0].Trim().ToUpper() == nombrePaciente.Trim().ToUpper())
                {
                    datos[1] = nuevaEsp.ToString(); // Cambiamos solo especialidad
                    lineas[i] = string.Join(",", datos); // Reconstruimos manteniendo el resto
                    encontrado = true;
                    break;
                }
            }

            if (encontrado)
            {
                File.WriteAllLines(ruta, lineas);
                Console.WriteLine("¡Especialidad actualizada con éxito!");
            }
            else
            {
                Console.WriteLine("Paciente no encontrado.");
            }
        }
    }
}
