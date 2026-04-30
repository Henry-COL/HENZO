using System;
using System.Collections.Generic;
using System.IO;
using System.Text;
using System.Windows.Forms;
using app_inventario.Models;

namespace app_inventario.Controllers
{
    public class ArticuloController
    {

        // Este método se encarga de crear los archivos si no existen
        public void InicializarArchivos()
        {
            string raiz = Path.GetFullPath(
                Path.Combine(Application.StartupPath, "..", "..")
            );

            string carpeta = Path.Combine(raiz, "DataBase");

            string[] archivos = { "Music.csv", "Purchased_music.csv", "uploaded_music.csv", "Usuarios.csv"};

            if (!Directory.Exists(carpeta))
                Directory.CreateDirectory(carpeta);

            foreach (string nombre in archivos)
            {
                string ruta = Path.Combine(carpeta, nombre);
                if (!File.Exists(ruta))
                    File.Create(ruta).Dispose();
            }
        }

        // ── Ruta apuntando a la raíz del proyecto ────────────────────
        // Desde bin/Debug/ subimos 2 niveles hasta app_inventario/
        private string ObtenerRuta()
        {
            string raiz = Path.GetFullPath(Path.Combine(Application.StartupPath, "..", ".."));
            return Path.Combine(raiz, "DataBase", "Music.csv");
        }

        // ── GUARDAR un artículo en el CSV ─────────────────────────────
        public void RegistrarEnCsv(Articulo articulo)
        {
            string ruta = ObtenerRuta();
            string carpeta = Path.GetDirectoryName(ruta);

            if (!Directory.Exists(carpeta))
                Directory.CreateDirectory(carpeta);

            bool esNuevo = !File.Exists(ruta);

            using (StreamWriter escritor = new StreamWriter(ruta, true, Encoding.UTF8))
            {
                if (esNuevo)
                    escritor.WriteLine("Codigo;Titulo;Artistas;Tipo;Portada;Cantidad;Precio");

                escritor.WriteLine($"{articulo.Codigo};{articulo.Titulo};{articulo.Artistas};{articulo.TipoArticulo};{articulo.RutaPortada};{articulo.Cantidad};{articulo.Precio}");
            }
        }

        // ── CARGAR todos los artículos desde el CSV ───────────────────
        public List<Articulo> CargarDesdeCsv()
        {
            List<Articulo> lista = new List<Articulo>();
            string ruta = ObtenerRuta();

            if (!File.Exists(ruta)) return lista;

            string[] lineas = File.ReadAllLines(ruta, Encoding.UTF8);

            for (int i = 1; i < lineas.Length; i++)
            {
                if (string.IsNullOrWhiteSpace(lineas[i])) continue;

                string[] datos = lineas[i].Split(';');

                if (datos.Length < 7) continue;

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

            return lista;
        }

        // ── VERIFICAR si un código ya existe ──────────────────────────
        public bool CodigoExiste(string codigo)
        {
            List<Articulo> lista = CargarDesdeCsv();
            foreach (Articulo a in lista)
            {
                if (a.Codigo == codigo) return true;
            }
            return false;
        }
    }
}