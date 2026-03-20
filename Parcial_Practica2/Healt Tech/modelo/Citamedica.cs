using Parcial_Practica2.Healt_Tech.Enum;
using Parcial_Practica2.Healt_Tech.interfaz;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Parcial_Practica2.Healt_Tech.modelo
{
    public class Citamedica : IPrioritario
    {
        public string Paciente { get; set; }
        public Especialidad Especialidad { get; set; }

        public double CostoBase { get; set; }

        public Citamedica(string Paciente, Especialidad Especialidad, double CostoBase)
        {
            this.Paciente = Paciente;
            this.Especialidad = Especialidad;
            this.CostoBase = CostoBase;
        }

        public string ToCSV() => $"Nombre: {Paciente}, Especialidad: {Especialidad},Costo Base: $ {CostoBase}";

        public double AplicarDescuento()
        {
            double descuento = 0;
            switch (Especialidad)
            {
                case Especialidad Especialidad:
                    descuento = 0.20;
                    break;
            }
            return CostoBase * (CostoBase - descuento);
        }
    }
}
