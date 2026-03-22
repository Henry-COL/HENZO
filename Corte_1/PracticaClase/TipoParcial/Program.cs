using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TipoParcial.BibliotecaDigital.Interfaces;
using TipoParcial.BibliotecaDigital.Modelos;
using TipoParcial.BibliotecaDigital.Enums;

using System;
using System.Collections.Generic;
using TipoParcial.BibliotecaDigital.Interfaces;

namespace TipoParcial
{
    internal class Program
    {
        private enum MaterialTipo { Libro, AudioLibro, Revista }

        private class Material
        {
            public int Id { get; set; }
            public string Titulo { get; set; }
            public string Autor { get; set; }
            public int Anio { get; set; }
            public string Categoria { get; set; }
            public MaterialTipo Tipo { get; set; }
            public bool Prestado { get; set; }
            public DateTime FechaDevolucion { get; set; }
        }

        static void Main(string[] args)
        {
            var biblioteca = new List<Material>
            {
                new Material { Id = 1, Titulo = "Don Quijote", Autor = "Miguel de Cervantes", Anio = 1605, Categoria = "Novela", Tipo = MaterialTipo.Libro, Prestado = false },
                new Material { Id = 2, Titulo = "El Principito (Audio)", Autor = "Saint-Exupéry", Anio = 1943, Categoria = "Ficción", Tipo = MaterialTipo.AudioLibro, Prestado = false },
                new Material { Id = 3, Titulo = "Revista Ciencia Hoy", Autor = "Varios", Anio = 2022, Categoria = "Ciencia", Tipo = MaterialTipo.Revista, Prestado = false }
            };

            bool ejecutando = true;
            while (ejecutando)
            {
                MostrarMenuPrincipal();
                string entrada = Console.ReadLine();

                switch (entrada)
                {
                    case "1": MostrarInformacionGeneral(biblioteca); break;
                    case "2": MostrarPorTipo(biblioteca, MaterialTipo.AudioLibro); break;
                    case "3": MostrarPorTipo(biblioteca, MaterialTipo.Libro); break;
                    case "4": MostrarPorTipo(biblioteca, MaterialTipo.Revista); break;
                    case "5": PrestarMaterial(biblioteca); break;
                    case "6": DevolverMaterial(biblioteca); break;
                    case "7": ejecutando = false; break;
                    default:
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.WriteLine("\n [!] Opción no válida.");
                        Pausar();
                        break;
                }
            }

            Console.Clear();
            Console.WriteLine("\n Sesión finalizada. ¡Éxitos en tu parcial!");
        }

        static void MostrarMenuPrincipal()
        {
            Console.Clear();
            Console.WriteLine("===========================================");
            Console.WriteLine("       BIBLIOTECA DIGITAL - CORTE 1       ");
            Console.WriteLine("===========================================");
            Console.ResetColor();
            Console.WriteLine("  1. Resumen de Inventario");
            Console.WriteLine("  2. Ver Audiolibros");
            Console.WriteLine("  3. Ver Libros");
            Console.WriteLine("  4. Ver Revistas");
            Console.WriteLine("  5. Gestionar Préstamo");
            Console.WriteLine("  6. Gestionar Devolución");
            Console.WriteLine("  7. Salir");
            Console.WriteLine("-------------------------------------------");
            Console.Write(" >> Selección: ");
        }

        private static void MostrarInformacionGeneral(List<Material> biblioteca)
        {
            Console.Clear();
            Console.WriteLine(">>> RESUMEN DE LA BIBLIOTECA <<< \n");

            int libros = biblioteca.Count(m => m.Tipo == MaterialTipo.Libro);
            int audiolibros = biblioteca.Count(m => m.Tipo == MaterialTipo.AudioLibro);
            int revistas = biblioteca.Count(m => m.Tipo == MaterialTipo.Revista);
            int prestados = biblioteca.Count(m => m.Prestado);

            Console.WriteLine($" [-] Libros: {libros}");
            Console.WriteLine($" [-] Audiolibros: {audiolibros}");
            Console.WriteLine($" [-] Revistas: {revistas}");
            Console.WriteLine($" [-] En préstamo: {prestados}");

            Pausar();
        }

        private static void MostrarPorTipo(List<Material> biblioteca, MaterialTipo tipo)
        {
            Console.Clear();
            Console.WriteLine($">>> LISTADO DE {tipo.ToString().ToUpper()}S <<<\n");

            var lista = biblioteca.FindAll(m => m.Tipo == tipo && !m.Prestado);
            if (lista.Count == 0)
            {
                Console.WriteLine(" No hay elementos disponibles en esta categoría.");
            }
            else
            {
                foreach (var m in lista)
                {
                    Console.WriteLine($" ID: {m.Id,-3} | {m.Titulo,-25} | {m.Autor}");
                }
            }
            Pausar();
        }

        private static void PrestarMaterial(List<Material> biblioteca)
        {
            Console.Clear();
            Console.WriteLine(">>> REGISTRO DE PRÉSTAMO <<<\n");

            Console.Write(" Ingrese el ID del material: ");
            if (int.TryParse(Console.ReadLine(), out int id))
            {
                var item = biblioteca.Find(m => m.Id == id);
                if (item != null && !item.Prestado)
                {
                    item.Prestado = true;
                    item.FechaDevolucion = DateTime.Now.AddDays(14);
                    Console.WriteLine($"\n [+] Éxito: '{item.Titulo}' prestado.");
                    Console.WriteLine($"     Devolver antes de: {item.FechaDevolucion:dd/MM/yyyy}");
                }
                else
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("\n [!] El material no existe o ya está prestado.");
                }
            }
            Pausar();
        }

        private static void DevolverMaterial(List<Material> biblioteca)
        {
            Console.Clear();
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine(">>> PROCESO DE DEVOLUCIÓN <<<\n");
            Console.ResetColor();

            Console.Write(" Ingrese el ID del material: ");
            if (int.TryParse(Console.ReadLine(), out int id))
            {
                var item = biblioteca.Find(m => m.Id == id);
                if (item != null && item.Prestado)
                {
                    int diasRetraso = (DateTime.Now.Date - item.FechaDevolucion.Date).Days;
                    item.Prestado = false;

                    if (diasRetraso > 0)
                    {
                        decimal multa = (decimal)diasRetraso * 1.5m;
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.WriteLine($"\n [!] Retraso de {diasRetraso} días. Multa: {multa:C}");
                    }
                    else
                    {
                        Console.WriteLine("\n [+] Devolución realizada a tiempo. Sin multas.");
                    }
                }
                else
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("\n [!] Error: El material no estaba marcado como prestado.");
                }
            }
            Pausar();
        }

        static void Pausar()
        {
            Console.ResetColor();
            Console.WriteLine("\n-------------------------------------------");
            Console.Write(" Presione cualquier tecla para continuar...");
            Console.ReadKey();
        }
    }
}