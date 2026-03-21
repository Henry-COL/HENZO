using Parcial_Corte1_Ejercicio1.AutoPartes_Express.Enums;
using Parcial_Corte1_Ejercicio1.AutoPartes_Express.Interfaces;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Parcial_Corte1_Ejercicio1.AutoPartes_Express.Modelos
{
    public class Repuesto : IGestionable
    {
        public int Id { get; set; }
        public double Precio { get; set; }
        public Categoria Categoria { get; set; }

        public Repuesto(int Id, double Precio, Categoria Categoria)
        {
            this.Id = Id;
            this.Precio = Precio;
            this.Categoria = Categoria;
        }

        public string ToCSV() => $"{Id},{Precio},{Categoria}";

        public void Ejecutar()
        {
            bool salir = false;
            while (!salir)
            {
                Console.Clear();
                Console.WriteLine("====== MENÚ REPUESTOS ======");
                Console.WriteLine("1. Crear");
                Console.WriteLine("2. Leer");
                Console.WriteLine("3. Actualizar");
                Console.WriteLine("4. Eliminar");
                Console.WriteLine("5. Salir");
                Console.Write("Seleccione una opción: ");

                string opcion = Console.ReadLine();

                switch (opcion)
                {
                    case "1":
                        Crear();
                        break;
                    case "2":
                        Leer();
                        break;
                    case "3":
                        Actualizar();
                        break;
                    case "4":
                        Eliminar();
                        break;
                    case "5":
                        salir = true;
                        break;
                    default:
                        Console.WriteLine("Opción no válida.");
                        Console.ReadKey();
                        break;
                }
            }
        }

        string ruta = "inventario.csv";

        public void Crear()
        {
            Console.Clear();
            Console.WriteLine("====== INGRESE LOS DATOS DEL REPUESTO ======");

            Console.Write("Ingrese el ID: ");
            int Id_Repuesto = int.Parse(Console.ReadLine());        
            Console.Write("Ingrese el precio: $ ");
            double Precio_Repuesto = double.Parse(Console.ReadLine());

            Console.WriteLine("Ingrese la Categoria (Motor - Frenos - Suspension): ");
            string entrada = Console.ReadLine();                      
            Categoria Categoria_Repuesto = (Categoria)Enum.Parse(typeof(Categoria), entrada, true);

            Console.WriteLine($"\nEl repuesto se ha guardado con los siguientes datos:" +
                              $" ID: {Id_Repuesto}, Precio: $ {Precio_Repuesto}, Categoria: {Categoria_Repuesto}");
            Console.ReadKey();
        }

        public void Leer()
        {
            Console.Clear();
            Console.WriteLine("====== INFORMACIÓN DE LOS RESPUESTOS ======");
            
            Console.ReadKey();
        }

        public void Actualizar()                                      
        {
            Console.Clear();
            Console.WriteLine("====== ACTUALIZAR REPUESTO ======");
            Console.WriteLine("Ingrese al ID del producto: ");
            string Id_Actualizar = Console.ReadLine();

            string[] lineas = File.ReadAllLines(ruta);
            bool encontrado = false;

            for (int i = 0; i < lineas.Length; i++)
            {
                string[] datos = lineas[i].Split(',');

                if (datos[0].Trim().ToUpper() == Id_Actualizar.Trim().ToUpper())
                {
                    Console.Write("Ingrese el nuevo precio: $ ");
                    double Nuevo_Precio = double.Parse(Console.ReadLine());
                    Console.WriteLine("Inrese la nueva categoría (Motor - Frenos - Suspension): ");
                    Categoria Nueva_Categoria = (Categoria)Enum.Parse(typeof(Categoria), Console.ReadLine(), true);

                    datos[1] = Nuevo_Precio.ToString();
                    datos[2] = Nueva_Categoria.ToString();
                    lineas[i] = string.Join(",", datos);
                    encontrado = true;
                    break;
                }
            }
            Console.ReadKey();
        }

        public void Eliminar()
        {
            Console.Clear();
            Console.WriteLine("====== ELIMINAR REPUESTO ======");
            Console.WriteLine($"¿Está seguro que desea eliminar el repuesto con ID {Id}? (S/N): ");
            string confirmacion = Console.ReadLine();

            if (confirmacion?.ToUpper() == "S")
            {
                Console.WriteLine("Repuesto eliminado correctamente.");
            }
            else
            {
                Console.WriteLine("Operación cancelada.");
            }
            Console.ReadKey();
        }
    }
}