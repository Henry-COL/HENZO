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
        private string ObtenerRuta()
        {
            string raiz = Path.GetFullPath(Path.Combine(Application.StartupPath, "..", ".."));
            return Path.Combine(raiz, "DataBase", "Music.csv");
        }

        private string ObtenerRutaEntradas()
        {
            string raiz = Path.GetFullPath(Path.Combine(Application.StartupPath, "..", ".."));
            return Path.Combine(raiz, "DataBase", "uploaded_music.csv");
        }

        private string ObtenerRutaSalidas()
        {
            string raiz = Path.GetFullPath(Path.Combine(Application.StartupPath, "..", ".."));
            return Path.Combine(raiz, "DataBase", "Purchased_music.csv");
        }

        public void InicializarArchivos()
        {
            string raiz = Path.GetFullPath(Path.Combine(Application.StartupPath, "..", ".."));
            string carpeta = Path.Combine(raiz, "DataBase");

            if (!Directory.Exists(carpeta))
                Directory.CreateDirectory(carpeta);

            foreach (string nombre in new[] { "Music.csv", "Purchased_music.csv", "uploaded_music.csv", "Usuarios.csv" })
            {
                string ruta = Path.Combine(carpeta, nombre);
                if (!File.Exists(ruta))
                    File.Create(ruta).Dispose();
            }
        }

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

        public List<string[]> CargarEntradas()
        {
            List<string[]> lista = new List<string[]>();
            string ruta = ObtenerRutaEntradas();

            if (!File.Exists(ruta)) return lista;

            string[] lineas = File.ReadAllLines(ruta, Encoding.UTF8);

            for (int i = 1; i < lineas.Length; i++)
            {
                if (string.IsNullOrWhiteSpace(lineas[i])) continue;

                string[] datos = lineas[i].Split(';');
                if (datos.Length < 5) continue;

                bool todosVacios = true;
                foreach (string d in datos)
                    if (!string.IsNullOrWhiteSpace(d)) { todosVacios = false; break; }

                if (todosVacios) continue;
                lista.Add(datos);
            }

            return lista;
        }

        public List<string[]> CargarSalidas()
        {
            List<string[]> lista = new List<string[]>();
            string ruta = ObtenerRutaSalidas();

            if (!File.Exists(ruta)) return lista;

            string[] lineas = File.ReadAllLines(ruta, Encoding.UTF8);

            for (int i = 1; i < lineas.Length; i++)
            {
                if (string.IsNullOrWhiteSpace(lineas[i])) continue;

                string[] datos = lineas[i].Split(';');
                if (datos.Length < 5) continue;

                bool todosVacios = true;
                foreach (string d in datos)
                    if (!string.IsNullOrWhiteSpace(d)) { todosVacios = false; break; }

                if (todosVacios) continue;
                lista.Add(datos);
            }

            return lista;
        }

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

        public void RegistrarEntrada(string codigo, string titulo, int cantidad, string observacion)
        {
            string ruta = ObtenerRutaEntradas();
            bool esNuevo = !File.Exists(ruta) || new FileInfo(ruta).Length == 0;

            using (StreamWriter escritor = new StreamWriter(ruta, true, Encoding.UTF8))
            {
                if (esNuevo)
                    escritor.WriteLine("Fecha;Codigo;Titulo;Cantidad;Observacion");

                escritor.WriteLine($"{DateTime.Now:dd/MM/yyyy};{codigo};{titulo};+{cantidad};{observacion}");
            }

            string[] lineas = File.ReadAllLines(ruta, Encoding.UTF8);
            File.WriteAllLines(ruta, Array.FindAll(lineas, l => !string.IsNullOrWhiteSpace(l)), Encoding.UTF8);
        }

        public void RegistrarSalida(string codigo, string titulo, int cantidad, string observacion)
        {
            string ruta = ObtenerRutaSalidas();
            bool esNuevo = !File.Exists(ruta) || new FileInfo(ruta).Length == 0;

            using (StreamWriter escritor = new StreamWriter(ruta, true, Encoding.UTF8))
            {
                if (esNuevo)
                    escritor.WriteLine("Fecha;Codigo;Titulo;Cantidad;Observacion");

                escritor.WriteLine($"{DateTime.Now:dd/MM/yyyy};{codigo};{titulo};-{cantidad};{observacion}");
            }

            string[] lineas = File.ReadAllLines(ruta, Encoding.UTF8);
            File.WriteAllLines(ruta, Array.FindAll(lineas, l => !string.IsNullOrWhiteSpace(l)), Encoding.UTF8);
        }

        public void ActualizarCantidad(string codigo, int cantidadSumar)
        {
            string ruta = ObtenerRuta();
            string[] lineas = File.ReadAllLines(ruta, Encoding.UTF8);

            for (int i = 1; i < lineas.Length; i++)
            {
                if (string.IsNullOrWhiteSpace(lineas[i])) continue;
                string[] datos = lineas[i].Split(';');

                if (datos[0].Trim() == codigo.Trim())
                {
                    datos[5] = (int.Parse(datos[5]) + cantidadSumar).ToString();
                    lineas[i] = string.Join(";", datos);
                    break;
                }
            }

            File.WriteAllLines(ruta, lineas, Encoding.UTF8);
        }

        public void RestarCantidad(string codigo, int cantidadRestar)
        {
            string ruta = ObtenerRuta();
            string[] lineas = File.ReadAllLines(ruta, Encoding.UTF8);

            for (int i = 1; i < lineas.Length; i++)
            {
                if (string.IsNullOrWhiteSpace(lineas[i])) continue;
                string[] datos = lineas[i].Split(';');

                if (datos[0].Trim() == codigo.Trim())
                {
                    int actual = int.Parse(datos[5]);
                    datos[5] = Math.Max(0, actual - cantidadRestar).ToString();
                    lineas[i] = string.Join(";", datos);
                    break;
                }
            }

            File.WriteAllLines(ruta, lineas, Encoding.UTF8);
        }

        public bool CodigoExiste(string codigo)
        {
            return CargarDesdeCsv().Exists(a => a.Codigo == codigo);
        }

        public List<string> ObtenerMusicaParaComboBox()
        {
            List<string> items = new List<string>();
            string ruta = ObtenerRuta();

            if (!File.Exists(ruta)) return items;

            string[] lineas = File.ReadAllLines(ruta, Encoding.UTF8);
            if (lineas.Length < 2) return items;

            string[] encabezado = lineas[0].Split(';');
            int idxCodigo = -1, idxTitulo = -1;

            for (int i = 0; i < encabezado.Length; i++)
            {
                string col = encabezado[i].Trim().ToUpper()
                              .Replace("Ó", "O")
                              .Replace("Í", "I");

                if (col == "CODIGO") idxCodigo = i;
                if (col == "TITULO") idxTitulo = i;
            }

            if (idxCodigo == -1 || idxTitulo == -1) return items;

            foreach (Articulo a in CargarDesdeCsv())
                items.Add($"{a.Codigo} - {a.Titulo}");

            return items;
        }

        public List<Articulo> ObtenerMasPopulares()
        {
            List<Articulo> lista = CargarDesdeCsv();
            lista.Sort((a, b) => b.Cantidad.CompareTo(a.Cantidad));
            return lista.Count >= 3 ? lista.GetRange(0, 3) : lista;
        }

        public List<Articulo> ObtenerRecienAnadidos()
        {
            List<Articulo> lista = CargarDesdeCsv();
            lista.Reverse();
            return lista.Count >= 3 ? lista.GetRange(0, 3) : lista;
        }
    }
}