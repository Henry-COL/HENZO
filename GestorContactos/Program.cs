using GestorContactos.Modelos;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GestorContactos
{
    internal class Program
    {
        static void Main()
        {
            string rutaArchivo = "contactos.csv";
            Contacto nuevoContacto = new Contacto();

            // Paso 2: Solicitar los tres datos al usuario por teclado
            Console.WriteLine("--- Registro de Nuevo Contacto ---");

            Console.Write("Ingrese el Nombre: ");
            nuevoContacto.Nombre = Console.ReadLine();

            Console.Write("Ingrese el Teléfono: ");
            nuevoContacto.Telefono = Console.ReadLine();

            Console.Write("Ingrese el Correo electrónico: ");
            string entradaCorreo = Console.ReadLine();

            // Paso 5: Validación y normalización antes de guardar
            nuevoContacto.Correo = entradaCorreo.Trim().ToLower();

            // Paso 4: Guardar el contacto en el archivo
            // El parámetro 'true' en StreamWriter permite agregar (append) sin borrar lo previo
            using (StreamWriter sw = new StreamWriter(rutaArchivo, true))
            {
                sw.WriteLine(nuevoContacto.ToCSV());
            }

            Console.WriteLine("\nContacto guardado exitosamente.");

            // Paso 6: Preguntar si desea listar
            Console.Write("\n¿Desea 'Listar contactos'? (si/no): ");
            string respuesta = Console.ReadLine().ToLower();

            if (respuesta == "si" || respuesta == "sí")
            {
                MostrarTabla(rutaArchivo);
            }
        }

        static void MostrarTabla(string ruta)
        {
            if (!File.Exists(ruta))
            {
                Console.WriteLine("El archivo no existe todavía.");
                return;
            }

            Console.WriteLine("\n{0,-20} | {1,-15} | {2,-30}", "NOMBRE", "TELÉFONO", "CORREO");
            Console.WriteLine(new string('-', 70));

            string[] lineas = File.ReadAllLines(ruta);
            foreach (string linea in lineas)
            {
                // Paso 6: Split por punto y coma
                string[] columnas = linea.Split(';');
                if (columnas.Length == 3)
                {
                    Console.WriteLine("{0,-20} | {1,-15} | {2,-30}", columnas[0], columnas[1], columnas[2]);
                }
            }
        }
    }
}
