using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TipoParcial.BibliotecaDigital.Interfaces;

namespace TipoParcial.BibliotecaDigital.Modelos
{
    public class AudioLibro : MaterialBiblioteca, IPrestable
    {
        public int duracion { get; set; }
        public string autorNarracion { get; set; }

        public AudioLibro(string titulo, string autor, int id, int anioPublicacion, string categoria, int duracion, string autorNarracion)
            : base(titulo, autor, id, anioPublicacion, categoria)
        {
            this.duracion = duracion;
            this.autorNarracion = autorNarracion;
        }

        public override void MostrarInformacion()
        {
            base.MostrarInformacion();
            Console.WriteLine($"Duración: {duracion} minutos");
            Console.WriteLine($"Autor de Narración: {autorNarracion}");
        }

        public DateTime CalcularFechaDevolcion()
        {
            return DateTime.Now.AddDays(14);
        }

        public void GenerarComprobantePrestamo()
        {
            Console.WriteLine($"Comprobante de préstamo generado para: {titulo} (ID: {id})");
        }

        public decimal CalcularMultaPorRetraso(int diasRetraso)
        {
            return diasRetraso * 0.5m;
        }
    }
}
