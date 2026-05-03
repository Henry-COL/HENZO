using System.IO;
using System.Text;

namespace app_inventario.Controllers
{
    public static class InstanciarArchivos
    {
        public static void InicializarArchivos()
        {
            string carpeta = RutaArchivos.ObtenerRutaDataBase();

            if (!Directory.Exists(carpeta))
                Directory.CreateDirectory(carpeta);

            CrearArchivoSiNoExiste(RutaArchivos.ObtenerRutaMusica(),
                "Codigo;Titulo;Artistas;Tipo;Portada;Cantidad;Precio");

            CrearArchivoSiNoExiste(RutaArchivos.ObtenerRutaEntradas(),
                "Fecha;Codigo;Titulo;Cantidad;Observacion");

            CrearArchivoSiNoExiste(RutaArchivos.ObtenerRutaSalidas(),
                "Fecha;Codigo;Titulo;Cantidad;Observacion");

            CrearArchivoSiNoExiste(RutaArchivos.ObtenerRutaUsuarios(), "");
        }

        private static void CrearArchivoSiNoExiste(string ruta, string encabezado)
        {
            if (!File.Exists(ruta))
            {
                using (StreamWriter escritor = new StreamWriter(ruta, false, Encoding.UTF8))
                {
                    if (!string.IsNullOrEmpty(encabezado))
                        escritor.WriteLine(encabezado);
                }
            }
        }
    }
}