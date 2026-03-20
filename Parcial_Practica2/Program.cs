using System;
using System.Collections.Generic;
using Parcial_Practica2.Healt_Tech.modelo;

namespace Parcial_Practica2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Crear algunas citas de ejemplo
            var citas = new List<Citamedica>
            {
                new Citamedica("Juan Perez", "pediatra", 100.0),
                new Citamedica("María Gómez", "general", 150.0),
                new Citamedica("Luis Rodríguez", "Pediatra", 200.0)
            };

            Console.WriteLine("Listado de citas y precio con descuento (si aplica):\n");

            foreach (var cita in citas)
            {
                double precioFinal = cita.calculardescuento();
                Console.WriteLine($"Paciente: {cita.paciente}");
                Console.WriteLine($"Especialidad: {cita.especialidad}");
                Console.WriteLine($"Precio base: {cita.costobase:C}");
                Console.WriteLine($"Precio con descuento: {precioFinal:C}\n");
            }

            Console.WriteLine("Presione una tecla para salir...");
            Console.ReadKey();
        }
    }
}
