using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TipoParcial.BibliotecaDigital.Interfaces
{
    public interface IPrestable
    {

        DateTime CalcularFechaDevolcion();
        void GenerarComprobantePrestamo();
        decimal CalcularMultaPorRetraso(int diasRetraso);

    }
}
