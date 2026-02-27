using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Corte_1.Ejercicios_Basicos.Inventario
{
    public class Producto
    {
        public string Nombre;
        public double Precio_Producto;
        public int Cantidad_Stock;
        public int Cantidad;

        public Producto(string nombre, double precio, int cantidad)
        {
            Nombre = nombre;
            Precio_Producto = precio;
            Cantidad_Stock = cantidad;
        }

        public void VenderProducto()
        {
            if (Cantidad <= 0)
            {
                Console.WriteLine("La cantidad a vender debe ser mayor que cero.");
                return;
            }

            if (Cantidad <= Cantidad_Stock)
            {
                Cantidad_Stock -= Cantidad;
                double totalVenta = Cantidad * Precio_Producto;

                Console.WriteLine("\n==== VENTA REALIZADA ====");
                Console.WriteLine("Producto: " + Nombre);
                Console.WriteLine("Unidades: " + Cantidad);
                Console.WriteLine("Total: $ " + totalVenta);
                Console.WriteLine("Stock restante: " + Cantidad_Stock);
            }
            else
            {
                Console.WriteLine("ERROR: No hay suficiente stock de " + Nombre);
                Console.WriteLine("Stock disponible: " + Cantidad_Stock);
            }
        }
    }
}