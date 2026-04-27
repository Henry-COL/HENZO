using System;
using System.Collections.Generic;
using System.IO;
using System.Text;
using app_inventario.Models;

namespace app_inventario.Controllers
{
    public class ArticuloController
    {
        // Esta lógica busca la carpeta raíz del proyecto subiendo desde bin/Debug
        private string ObtenerRutaProyecto()
        {
            // Esto sube desde bin/Debug hasta la raíz de tu proyecto app_inventario
            string rutaBase = AppDomain.CurrentDomain.BaseDirectory;
            DirectoryInfo directorioProyecto = Directory.GetParent(rutaBase).Parent.Parent.Parent;

            // Aquí concatenamos con tu carpeta DataBase real
            return Path.Combine(directorioProyecto.FullName, "DataBase", "Music.csv");
        }

        public void RegistrarEnCsv(Articulo articulo)
        {
            try
            {
                string rutaFinal = ObtenerRutaProyecto();
                string directorio = Path.GetDirectoryName(rutaFinal);

                if (!Directory.Exists(directorio)) Directory.CreateDirectory(directorio);

                bool existeArchivo = File.Exists(rutaFinal);

                // 'true' para añadir datos (append) sin borrar lo anterior
                using (StreamWriter escritor = new StreamWriter(rutaFinal, true, Encoding.UTF8))
                {
                    if (!existeArchivo)
                    {
                        escritor.WriteLine("Codigo;Titulo;Artistas;Tipo;Portada;Cantidad;Precio");
                    }

                    escritor.WriteLine($"{articulo.Codigo};{articulo.Titulo};{articulo.Artistas};{articulo.TipoArticulo};{articulo.RutaPortada};{articulo.Cantidad};{articulo.Precio}");
                }
            }
            catch (Exception ex)
            {
                throw new Exception("Error al guardar en el archivo de origen: " + ex.Message);
            }
        }

        public List<Articulo> CargarDesdeCsv()
        {
            List<Articulo> lista = new List<Articulo>();
            string rutaFinal = ObtenerRutaProyecto();

            if (!File.Exists(rutaFinal)) return lista;

            try
            {
                string[] lineas = File.ReadAllLines(rutaFinal, Encoding.UTF8);
                for (int i = 1; i < lineas.Length; i++)
                {
                    if (string.IsNullOrWhiteSpace(lineas[i])) continue;
                    string[] datos = lineas[i].Split(';');

                    if (datos.Length >= 7)
                    {
                        lista.Add(new Articulo
                        {
                            Codigo = datos[0],
                            Titulo = datos[1],
                            Artistas = datos[2],
                            TipoArticulo = datos[3],
                            RutaPortada = datos[4],
                            Cantidad = int.Parse(datos[5]),
                            Precio = decimal.Parse(datos[6])
                        });
                    }
                }
            }
            catch (Exception ex) { throw new Exception("Error al cargar desde origen: " + ex.Message); }
            return lista;
        }
    }
}