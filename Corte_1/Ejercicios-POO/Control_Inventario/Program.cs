using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Control_Inventario
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string nombre = "Laptop";
            int codigo = 101;
            double precio = 1500.00;
            int stockActual = 10;

            while (true)
            {
                Console.Clear();
                Console.WriteLine("========================================");
                Console.WriteLine("       SISTEMA DE INVENTARIO");
                Console.WriteLine("========================================");

                Console.WriteLine("\nPRODUCTO EN SISTEMA:");
                Console.WriteLine("------------------------------------------------------------------");
                Console.WriteLine($"ID: {codigo} | Nombre: {nombre} | Precio: ${precio} | Stock: {stockActual}");
                Console.WriteLine("------------------------------------------------------------------");

                Console.WriteLine("\n1. Actualizar Stock (Agregar)");
                Console.WriteLine("2. Vender (Quitar)");
                Console.WriteLine("3. Salir");
                Console.Write("\nSeleccione una opción: ");
                string opcion = Console.ReadLine();

                if (opcion == "1")
                {
                    Console.Write("\nCantidad a sumar al stock: ");
                    int cantidad = int.Parse(Console.ReadLine());

                    Inventario.AgregarStock transaccion = new Inventario.AgregarStock(nombre, codigo, precio, stockActual, cantidad);
                    transaccion.MostrarInformacion();

                    stockActual = transaccion.StockProducto;
                    Console.Write("\nPresione una tecla para continuar...");
                    Console.ReadKey();
                }

                if (opcion == "2")
                {
                    Console.Write("\nCantidad a vender: ");
                    int cantidad = int.Parse(Console.ReadLine());

                    if (cantidad <= stockActual)
                    {
                        stockActual -= cantidad;
                        Console.WriteLine("\nVenta realizada con éxito.");
                    }
                    else
                    {
                        Console.WriteLine("\nError: Stock insuficiente.");
                    }

                    Console.Write("\nPresione una tecla para continuar...");
                    Console.ReadKey();
                }

                if (opcion == "3")
                {
                    break;
                }
            }
        }
    }
}