using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Corte_1.Ejercicios_Basicos.Vehiculos_Electricos
{
    public class VehiculoElectrico
    {
        public string modelo;
        public int bateria;
        public VehiculoElectrico(string modeloAuto, int cargaInicial)
        {
            modelo = modeloAuto;
            bateria = cargaInicial;
        }
        public void Viajar(int km)
        {
            if (bateria <= 0)
            {
                Console.WriteLine("Error: El vehículo no tiene carga para iniciar el viaje.");
                return;
            }
            bateria = bateria - km;
            if (bateria <= 0)
            {
                bateria = 0;
                Console.WriteLine("ALERTA: " + modelo + " se ha quedado sin energía. NECESITA CARGA INMEDIATA.");
            }
            else
            {
                Console.WriteLine("Viaje completado. Batería restante: " + bateria + "%");
            }
        }
    }
}
