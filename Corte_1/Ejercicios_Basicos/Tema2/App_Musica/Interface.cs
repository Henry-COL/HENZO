using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Corte_1.Ejercicios_Basicos.App_Musica
{
    public interface IReproductor
    {
        // Añadido: propiedad Titulo para que el código consumidor pueda acceder al título
        string Titulo { get; }
        void Play();
        void Stop();
    }
}
