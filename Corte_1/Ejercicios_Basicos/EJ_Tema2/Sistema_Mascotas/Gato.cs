using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Corte_1.Ejercicios_Basicos.Sistema_Mascotas
{
    public class Gato : Mascota
    {
        public override void HacerTruco()
        {
            Console.WriteLine($"{Nombre} está amasando un pan.");
        }
    }
}