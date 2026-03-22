using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TipoParcial2.ConcesionarioVehiculos.Enumns;
using TipoParcial2.ConcesionarioVehiculos.Interfaces;

namespace TipoParcial2.ConcesionarioVehiculos.Modelos
{
    public class Camion : Vehiculo, IVendible
    {
        public decimal CapacidadCarga { get; set; }
        public int NumeroEjes { get; set; }

        public Camion(string Id, string Marca, string Modelo, int Año, decimal PrecioBase, TipoCombustible Combustible, EstadoVehiculo Estado, decimal CapacidadCarga, int NumeroEjes)
            : base(Id, Marca, Modelo, Año, PrecioBase, Combustible, Estado)
        {
            this.CapacidadCarga = CapacidadCarga;
            this.NumeroEjes = NumeroEjes;
        }

        public decimal CalcularPrecioFinal()
        {
            return PrecioBase + (CapacidadCarga * 500);
        }

        public decimal CalcularComisionVendedor()
        {
            return CalcularPrecioFinal() * 0.04m;
        }

        public void GenerarFacturaVenta()
        {
            Console.WriteLine("======== FACTURA DE VENTA: CAMIÓN ========");
            Console.WriteLine($"Id: {Id}");
            Console.WriteLine($"Marca: {Marca}");
            Console.WriteLine($"Modelo: {Modelo}");
            Console.WriteLine($"Capacidad de Carga: {CapacidadCarga} Toneladas");
            Console.WriteLine($"Número de Ejes: {NumeroEjes}");
            Console.WriteLine($"Precio Base: {PrecioBase:C}");
            Console.WriteLine($"Precio Final: {CalcularPrecioFinal():C}");
            Console.WriteLine($"Comisión del Vendedor: {CalcularComisionVendedor():C}");
            Console.WriteLine("==========================================");
        }
    }
}
