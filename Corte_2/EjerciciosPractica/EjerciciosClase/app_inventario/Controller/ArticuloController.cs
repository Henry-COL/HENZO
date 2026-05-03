using app_inventario.Models;
using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace app_inventario.Controllers
{
    public class ArticuloController
    {
        // ── Carga ─────────────────────────────────────────────────────
        public void InicializarArchivos()
        {
            InstanciarArchivos.InicializarArchivos();
        }

        public List<Articulo> CargarDesdeCsv()
        {
            List<Articulo> lista = new List<Articulo>();
            string ruta = RutaArchivos.ObtenerRutaMusica();

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

        public List<EntradaMusica> CargarEntradas()
        {
            List<EntradaMusica> lista = new List<EntradaMusica>();
            string ruta = RutaArchivos.ObtenerRutaEntradas();

            if (!File.Exists(ruta)) return lista;

            string[] lineas = File.ReadAllLines(ruta, Encoding.UTF8);

            for (int i = 1; i < lineas.Length; i++)
            {
                if (string.IsNullOrWhiteSpace(lineas[i])) continue;
                string[] datos = lineas[i].Split(';');
                if (datos.Length < 5) continue;

                lista.Add(new EntradaMusica
                {
                    Fecha = datos[0],
                    Codigo = datos[1],
                    Titulo = datos[2],
                    Cantidad = datos[3],
                    Observacion = datos[4]
                });
            }
            return lista;
        }

        public List<SalidaMusica> CargarSalidas()
        {
            List<SalidaMusica> lista = new List<SalidaMusica>();
            string ruta = RutaArchivos.ObtenerRutaSalidas();

            if (!File.Exists(ruta)) return lista;

            string[] lineas = File.ReadAllLines(ruta, Encoding.UTF8);

            for (int i = 1; i < lineas.Length; i++)
            {
                if (string.IsNullOrWhiteSpace(lineas[i])) continue;
                string[] datos = lineas[i].Split(';');
                if (datos.Length < 5) continue;

                lista.Add(new SalidaMusica
                {
                    Fecha = datos[0],
                    Codigo = datos[1],
                    Titulo = datos[2],
                    Cantidad = datos[3],
                    Observacion = datos[4]
                });
            }
            return lista;
        }

        // ── Registro ──────────────────────────────────────────────────
        public void RegistrarEnCsv(Articulo articulo)
        {
            string ruta = RutaArchivos.ObtenerRutaMusica();

            using (StreamWriter escritor = new StreamWriter(ruta, true, Encoding.UTF8))
            {
                escritor.WriteLine(
                    $"{articulo.Codigo};{articulo.Titulo};{articulo.Artistas};" +
                    $"{articulo.TipoArticulo};{articulo.RutaPortada};" +
                    $"{articulo.Cantidad};{articulo.Precio}");
            }
        }

        public void RegistrarEntrada(string codigo, string titulo, int cantidad, string observacion)
        {
            string ruta = RutaArchivos.ObtenerRutaEntradas();

            using (StreamWriter escritor = new StreamWriter(ruta, true, Encoding.UTF8))
            {
                escritor.WriteLine(
                    $"{DateTime.Now:dd/MM/yyyy};{codigo};{titulo};+{cantidad};{observacion}");
            }

            LimpiarLineasVacias(ruta);
        }

        public void RegistrarSalida(string codigo, string titulo, int cantidad, string observacion)
        {
            string ruta = RutaArchivos.ObtenerRutaSalidas();

            using (StreamWriter escritor = new StreamWriter(ruta, true, Encoding.UTF8))
            {
                escritor.WriteLine(
                    $"{DateTime.Now:dd/MM/yyyy};{codigo};{titulo};-{cantidad};{observacion}");
            }

            LimpiarLineasVacias(ruta);
        }

        // ── Actualizar stock ──────────────────────────────────────────
        public void ActualizarCantidad(string codigo, int cantidadSumar)
        {
            ActualizarStock(codigo, cantidadSumar, sumar: true);
        }

        public void RestarCantidad(string codigo, int cantidadRestar)
        {
            ActualizarStock(codigo, cantidadRestar, sumar: false);
        }

        private void ActualizarStock(string codigo, int cantidad, bool sumar)
        {
            string ruta = RutaArchivos.ObtenerRutaMusica();
            string[] lineas = File.ReadAllLines(ruta, Encoding.UTF8);

            for (int i = 1; i < lineas.Length; i++)
            {
                if (string.IsNullOrWhiteSpace(lineas[i])) continue;
                string[] datos = lineas[i].Split(';');

                if (datos[0].Trim() != codigo.Trim()) continue;

                int actual = int.Parse(datos[5]);
                datos[5] = sumar
                    ? (actual + cantidad).ToString()
                    : Math.Max(0, actual - cantidad).ToString();

                lineas[i] = string.Join(";", datos);
                break;
            }

            File.WriteAllLines(ruta, lineas, Encoding.UTF8);
        }

        // ── Consultas ─────────────────────────────────────────────────
        public bool CodigoExiste(string codigo)
        {
            return CargarDesdeCsv().Exists(a => a.Codigo == codigo);
        }

        public List<string> ObtenerMusicaParaComboBox()
        {
            List<string> items = new List<string>();
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

        // ── Privados ──────────────────────────────────────────────────
        private void LimpiarLineasVacias(string ruta)
        {
            string[] lineas = File.ReadAllLines(ruta, Encoding.UTF8);
            File.WriteAllLines(ruta, Array.FindAll(lineas,
                l => !string.IsNullOrWhiteSpace(l)), Encoding.UTF8);
        }
    }
}