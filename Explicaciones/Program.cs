using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GuiaEstudio_Semana4_Completa
{
    // CLASE PARA EJEMPLO DE DATOS ESTRUCTURADOS (Seccion 5 de la guia)
    public class Estudiante
    {
        public string Id { get; set; }
        public string Nombre { get; set; }
        public double Nota { get; set; }

        // Metodo para convertir el objeto a una linea de texto separada por puntos y coma
        public string ToCSV() => $"{Id};{Nombre};{Nota}";
    }

    internal class Program
    {
        static void Main(string[] args)
        {
            // CONFIGURACION INICIAL (Seccion 4 de la guia)
            string carpeta = "MisDatos";
            if (!Directory.Exists(carpeta)) Directory.CreateDirectory(carpeta);

            // LLAMADO A LAS FUNCIONES DE EXPLICACION
            ExplicacionDeDateTime();
            ExplicacionDeCadenas();
            ExplicacionDeArchivosTxt(carpeta);
            ExplicacionDeCSVEnMain(carpeta); // Ejemplo de creacion directa
            ExplicacionDeCSVConClase(carpeta); // Ejemplo organizado con clase

            Console.WriteLine("\nProceso finalizado con todos los puntos de la guia.");
            Console.ReadKey();
        }

        static void ExplicacionDeDateTime()
        {
            Console.WriteLine("--- 1. MANEJO DE TIEMPO (DateTime) ---");
            // Para calcular entre 2 fechas necesitas tomar dos DateTime y restarlos.
            // El resultado siempre sera un TimeSpan (Intervalo de tiempo).

            DateTime ahora = DateTime.Now;
            DateTime entrega = new DateTime(2026, 03, 25);

            TimeSpan diferencia = entrega - ahora;
            Console.WriteLine("Dias restantes para la entrega: " + diferencia.Days);

            // Los DateTime son inmutables: AddDays devuelve una fecha nueva.
            DateTime fechaNueva = ahora.AddDays(5);
            Console.WriteLine("Fecha en 5 dias: " + fechaNueva.ToString("dd/MM/yyyy"));
        }

        static void ExplicacionDeCadenas()
        {
            Console.WriteLine("\n--- 2. MANEJO DE TEXTO (String y StringBuilder) ---");
            // StringBuilder es mas eficiente para unir muchos textos sin gastar memoria extra.

            StringBuilder sb = new StringBuilder();
            sb.Append("Registro de sistema: ");
            sb.AppendLine("Operacion exitosa.");

            string resultado = sb.ToString();
            Console.WriteLine(resultado.Trim()); // Trim quita espacios en los extremos
        }

        static void ExplicacionDeArchivosTxt(string carpeta)
        {
            Console.WriteLine("\n--- 3. ARCHIVOS DE TEXTO (.txt) ---");
            string ruta = Path.Combine(carpeta, "notas.txt");

            // WriteAllText sobrescribe; AppendAllText agrega al final.
            File.WriteAllText(ruta, "Linea inicial" + Environment.NewLine);
            File.AppendAllText(ruta, "Linea añadida" + Environment.NewLine);

            if (File.Exists(ruta))
            {
                // ReadAllLines devuelve un arreglo con todas las lineas del archivo.
                string[] contenido = File.ReadAllLines(ruta);
                Console.WriteLine("Se leyeron " + contenido.Length + " lineas.");
            }
        }

        static void ExplicacionDeCSVEnMain(string carpeta)
        {
            Console.WriteLine("\n--- 4. CREACION DE CSV DESDE EL MAIN ---");
            // Cuando va en el Main, tu controlas manualmente la creacion y la ruta.
            string rutaCsv = Path.Combine(carpeta, "datos_main.csv");

            // Se crea el encabezado si el archivo no existe
            if (!File.Exists(rutaCsv))
            {
                File.WriteAllText(rutaCsv, "ID;Nombre;Nota" + Environment.NewLine);
            }

            string nuevaFila = "101;Henry;4.8";
            File.AppendAllText(rutaCsv, nuevaFila + Environment.NewLine);
            Console.WriteLine("Archivo CSV creado y guardado directamente desde el Main.");
        }

        static void ExplicacionDeCSVConClase(string carpeta)
        {
            Console.WriteLine("\n--- 5. CREACION DE CSV CON CLASES (POO) ---");
            // Aqui usamos el objeto Estudiante definido arriba.
            // Es mas organizado porque la logica de "como se ve el CSV" esta en la clase.

            string rutaCsv = Path.Combine(carpeta, "estudiantes_clase.csv");

            Estudiante est = new Estudiante { Id = "202", Nombre = "Carlos", Nota = 3.5 };

            // Usamos el metodo ToCSV() de la clase para enviar la informacion
            File.AppendAllText(rutaCsv, est.ToCSV() + Environment.NewLine);
            Console.WriteLine("Registro guardado usando la estructura de la clase Estudiante.");
        }
    }
}
