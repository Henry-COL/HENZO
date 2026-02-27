using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Corte_1.Ejercicios_Basicos.Sistema_Mascotas
{
    public class Loro : Mascota
    {
        public string FraseRepetir;

        public override void HacerTruco()
        {
            Console.Write($"Escriba la frase que quiera que {Nombre} repita: ");
            FraseRepetir = Console.ReadLine();
            Console.WriteLine($"{Nombre} repite: {FraseRepetir}");
        }
    }
}
