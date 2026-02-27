using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Corte_1.Ejercicios_Basicos.EJ_Tema1.Simulador_Semaforo
{
    public class SemaforoInteligente
    {
        public string ColorActual;

        public SemaforoInteligente(string color)
        {
            ColorActual = color.ToLower().Trim();
        }

        public void MostrarAccion()
        {
            Console.WriteLine("\n========================================");

            if (ColorActual == "verde")
            {
                Console.WriteLine("Accion: Sigue adelante");
            }
            else if (ColorActual == "amarillo")
            {
                Console.WriteLine("Accion: Preparate para frenar");
            }
            else if (ColorActual == "rojo")
            {
                Console.WriteLine("Accion: ¡Detente!");
            }
            else
            {
                Console.WriteLine("Color no reconocido. Intente de nuevo.");
            }

            Console.WriteLine("========================================\n");
        }
    }
}