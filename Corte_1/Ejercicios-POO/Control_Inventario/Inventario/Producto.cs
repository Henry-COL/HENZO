using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Control_Inventario.Inventario
{
    public class Producto
    {
        public string NombreProducto;
        public int CodigoProducto;
        public int StockProducto;
        public double PrecioProducto;

        public Producto(string nombreProducto, int codigoProducto, double precioProducto, int stockProducto)
        {
            this.NombreProducto = nombreProducto.Trim();
            this.CodigoProducto = codigoProducto;
            this.PrecioProducto = precioProducto;
            this.StockProducto = stockProducto;
        }

        public virtual void MostrarInformacion()
        {
            Console.WriteLine("\n===== Inventario =====");
            Console.WriteLine($"ID: {CodigoProducto} | Producto: {NombreProducto} | Precio: ${PrecioProducto} | Stock: {StockProducto}");
        }
    }
}