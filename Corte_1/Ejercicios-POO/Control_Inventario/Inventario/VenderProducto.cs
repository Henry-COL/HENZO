using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Control_Inventario.Inventario
{
    public class VenderProducto : Producto
    {
        public int CantidadVender;

        public VenderProducto(string nombreProducto, int codigoProducto, double precioProducto, int stockProducto, int nuevaCantidad) : base(nombreProducto, codigoProducto, precioProducto, stockProducto)
        {
            this.CantidadVender = nuevaCantidad;
            if (CantidadVender > StockProducto)
            {
                Console.WriteLine($"No se puede vender {CantidadVender} unidades de {NombreProducto}. Stock insuficiente.");
                CantidadVender = 0;
            }
            else
            {
                this.StockProducto -= CantidadVender;
            }

        }

        public void MostrarResultado()
        {
            Console.WriteLine("=== Venta de Producto ===");
            Console.WriteLine($"Producto: {NombreProducto}");
            Console.WriteLine($"Cantidad vendida: {CantidadVender}");
            Console.WriteLine($"Stock restante: {StockProducto}");
            Console.WriteLine("=========================");
        }
    }
}
