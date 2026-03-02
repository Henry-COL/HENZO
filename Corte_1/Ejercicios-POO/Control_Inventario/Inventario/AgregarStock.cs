using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Control_Inventario.Inventario
{
    public class AgregarStock : Producto
    {
        public int NuevaCantidad;

        public AgregarStock(string nombreProducto, int codigoProducto, double precioProducto, int stockProducto, int nuevaCantidad) : base(nombreProducto, codigoProducto, precioProducto, stockProducto)
        {
            this.NuevaCantidad = nuevaCantidad;
            this.StockProducto += nuevaCantidad;
        }

        public void MostrarResultado()
        {
            Console.WriteLine("=== Actualización de Inventario ===");
            Console.WriteLine($"Producto: {NombreProducto}");
            Console.WriteLine($"Cantidad añadida: {NuevaCantidad}");
            Console.WriteLine($"Stock total ahora: {StockProducto}");
            Console.WriteLine("===================================");
        }
    }
}