using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practica_Casa1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Ingrese el nombre del proyecto");
            string name = Console.ReadLine();

            if (Directory.Exists(name))
            {
                Console.WriteLine("La carpeta ya existe, prueba usando otro nombre!");

            }
            else
            {
                Directory.CreateDirectory(name);
                string rutadocumento = Path.Combine(name, "documentos");
                Directory.CreateDirectory(rutadocumento);
                string rutaimagenes = Path.Combine(name, "imagenes");
                Directory.CreateDirectory(rutaimagenes);
                string rutacodigo = Path.Combine(name, "codigo");
                Directory.CreateDirectory(rutacodigo);
                Console.WriteLine("Ingrese la descripcion del proyecto");
                string description = Console.ReadLine();
                string rutareadme = Path.Combine(rutadocumento, "readme.txt");
                File.WriteAllText(rutareadme, description + Environment.NewLine);

                Console.WriteLine(Path.GetFullPath(name));
            }
        }
    }
}
