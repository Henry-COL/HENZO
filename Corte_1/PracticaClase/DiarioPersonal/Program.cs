using System;
using System.IO;
using System.Linq;

namespace DiarioPersonal
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // 1. Configuración de la carpeta
            string nombreCarpeta = "Diarios";
            // Obtenemos la ruta de la carpeta de ejecución (bin/Debug) y le sumamos "Diarios"
            string rutaDirectorio = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, nombreCarpeta);

            // 2. Crear la carpeta si no existe
            if (!Directory.Exists(rutaDirectorio))
            {
                Directory.CreateDirectory(rutaDirectorio);
            }

            Console.WriteLine("======= Bienvenido a tu diario personal =======");
            Console.Write("Ingresa tu nombre: ");
            string nombre = Console.ReadLine();

            Console.Write("¿Qué tienes en mente hoy?: ");
            string pensamiento = Console.ReadLine();

            // 3. Preparar el contenido con fecha y hora
            string fechaActual = DateTime.Now.ToString("dd/MM/yyyy HH:mm:ss");
            string entradaDiario = $"[{fechaActual}] - {nombre}: {pensamiento}" + Environment.NewLine;

            // 4. Construir la ruta del archivo correctamente
            // NOTA: Solo usamos el nombre del archivo, porque la carpeta ya está en 'rutaDirectorio'
            string nombreArchivo = $"{nombre}_diario.txt";
            string rutaCompleta = Path.Combine(rutaDirectorio, nombreArchivo);

            try
            {
                // 5. Guardar el archivo (AppendAllText agrega texto al final, no sobrescribe)
                File.AppendAllText(rutaCompleta, entradaDiario);

                Console.WriteLine("\n===============================================");
                Console.WriteLine("Pensamiento guardado con éxito.");
                Console.WriteLine($"Archivo: {rutaCompleta}");
                Console.WriteLine("===============================================");
            }
            catch (Exception ex)
            {
                Console.WriteLine($"\nHubo un error al guardar: {ex.Message}");
            }

            Console.Write("\nPresiona cualquier tecla para salir...");
            Console.ReadKey();
        }
    }
}
