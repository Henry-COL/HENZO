using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TipoParcial2.ConcesionarioVehiculos.Interfaces;
using TipoParcial2.ConcesionarioVehiculos.Enumns;

namespace TipoParcial2.ConcesionarioVehiculos.Modelos
{
    public class Auto : Vehiculo, IVendible
    {
        public int NumeroPuertas { get; set; }
        public bool TieneAireAcondicionado { get; set; }

        public Auto(string Id, string Marca, string Modelo, int Año, decimal PrecioBase, TipoCombustible Combustible, EstadoVehiculo Estado, int NumeroPuertas, bool TieneAireAcondicionado)
            : base(Id, Marca, Modelo, Año, PrecioBase, Combustible, Estado)
        {
            this.NumeroPuertas = NumeroPuertas;
            this.TieneAireAcondicionado = TieneAireAcondicionado;
        }

        public decimal CalcularPrecioFinal()
        {
            decimal PrecioFinal = PrecioBase;
            if (TieneAireAcondicionado == true)
            {
                PrecioFinal += 5000;
            }
            else             {
                PrecioFinal += 0;
            }
            return PrecioFinal;
        }

        public decimal CalcularComisionVendedor()
        {
            return CalcularPrecioFinal() * 0.04m;
        }
        public void GenerarFacturaVenta()
        {
            Console.WriteLine("======== FACTURA DE VENTA: AUTO ========");
            Console.WriteLine($"Id del Vehiculo: {Id}");
            Console.WriteLine($"Marca del Vehiculo: {Marca}");
            Console.WriteLine($"Modelo del Vehiculo: {Modelo}");
            Console.WriteLine($"Año del Vehiculo: {Año}");
            Console.WriteLine($"Precio Final: {CalcularPrecioFinal()}");
            Console.WriteLine($"Comisión del Vendedor: {CalcularComisionVendedor()}");
        }



    }
}
