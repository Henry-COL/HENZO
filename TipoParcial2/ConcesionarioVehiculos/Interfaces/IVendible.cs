using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TipoParcial2.ConcesionarioVehiculos.Interfaces
{
    public interface IVendible
    {
         decimal Precio { get; set; }
         string Marca { get; set; }
         string Modelo { get; set; }
         int Año { get; set; }
         Enumns.TipoCombustible TipoCombustible { get; set; }
         Enumns.EstadoVehiculo EstadoVehiculo { get; set; }

        public void MostrarInformacion();
    }
}
