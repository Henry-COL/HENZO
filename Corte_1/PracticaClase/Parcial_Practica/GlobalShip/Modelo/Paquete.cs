using Parcial_Practica.GlobalShip.Enum;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Parcial_Practica.GlobalShip.Modelo
{
    public class Paquete
    {
        public double Peso { get; set; }
        public int Guia { get; set; }
        public string Destinatario { get; set; }
        public Tipo TipoEnvio { get; set; }

        public Paquete(double peso, int guia, string destinatario, Tipo tipoEnvio)
        {
            Peso = peso;
            Guia = guia;
            Destinatario = destinatario;
            TipoEnvio = tipoEnvio; 
        }

        public string ToCSV() => $"{Guia};{Destinatario};{Peso};{TipoEnvio}";
    }
}