using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TipoParcial2.ConcesionarioVehiculos.Enumns;
using TipoParcial2.ConcesionarioVehiculos.Interfaces;

namespace TipoParcial2.ConcesionarioVehiculos.Modelos
{
    public class Motocicleta : Vehiculo, IVendible
    {
        public int Cilindraje { get; set; }
        public bool EsDeportiva { get; set; }

        public Motocicleta(string Id, string Marca, string Modelo, int Año, decimal PrecioBase, TipoCombustible Combustible, EstadoVehiculo Estado, int Cilindraje, bool EsDeportiva)
            : base(Id, Marca, Modelo, Año, PrecioBase, Combustible, Estado)
        {
            this.Cilindraje = Cilindraje;
            this.EsDeportiva = EsDeportiva;
        }

        public decimal CalcularPrecioFinal()
        {
            decimal adicional = EsDeportiva ? (decimal)(Cilindraje * 10) : 0;
            return PrecioBase + adicional;
        }

        public decimal CalcularComisionVendedor()
        {
            return CalcularPrecioFinal() * 0.04m;
        }

        public void GenerarFacturaVenta()
        {
            string tipoMoto = EsDeportiva ? "Deportiva" : "Estándar";

            Console.WriteLine("======== FACTURA DE VENTA: MOTOCICLETA ========");
            Console.WriteLine($"Id: {Id}");
            Console.WriteLine($"Marca: {Marca}");
            Console.WriteLine($"Modelo: {Modelo} ({Cilindraje}cc - {tipoMoto})");
            Console.WriteLine($"Año: {Año}");
            Console.WriteLine($"Precio Base: {PrecioBase:C}");
            Console.WriteLine($"Precio Final: {CalcularPrecioFinal():C}");
            Console.WriteLine($"Comisión del Vendedor: {CalcularComisionVendedor():C}");
            Console.WriteLine("===============================================");
        }
    }
}
