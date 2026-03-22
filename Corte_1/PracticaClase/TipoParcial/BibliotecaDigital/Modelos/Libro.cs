using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TipoParcial.BibliotecaDigital.Interfaces;

namespace TipoParcial.BibliotecaDigital.Modelos
{
    public class Libro : MaterialBiblioteca, IPrestable
    {
        public int NumeroPaginas { get; set; }
        public int ISBN { get; set; }

        public Libro(string titulo, string autor, int id, int anioPublicacion, string categoria, int numeroPaginas, int isbn)
            : base(titulo, autor, id, anioPublicacion, categoria)
        {
            this.NumeroPaginas = numeroPaginas;
            this.ISBN = isbn;
        }

        public override void MostrarInformacion()
        {
            base.MostrarInformacion();
            Console.WriteLine($"Número de Páginas: {NumeroPaginas}");
            Console.WriteLine($"ISBN: {ISBN}");
        }

        public DateTime CalcularFechaDevolcion()
        {
            return DateTime.Now.AddDays(14);
        }
        public void Prestar()
        {

        }

        public void Devolver()
        {

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
