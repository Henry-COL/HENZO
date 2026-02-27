using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Corte_1.Ejercicios_Basicos.EJ_Tema1.Aforo
{
    public class ControlAforo
    {
        public int AforoMaximo = 50;
        public int PersonasActuales;

        public ControlAforo(int actuales)
        {
            PersonasActuales = actuales;
        }

        public void ValidarIngreso(int quierenEntrar)
        {
            int espacioDisponible = AforoMaximo - PersonasActuales;
            Console.Clear();
            Console.WriteLine("========================================");
            if (quierenEntrar <= espacioDisponible)
            {
                Console.WriteLine("¡Bienvenidos! Pueden entrar.");
                PersonasActuales += quierenEntrar;
            }
            else
            {
                int faltante = quierenEntrar - espacioDisponible;
                Console.WriteLine("Cupo insuficiente.");
                Console.WriteLine("Deben salir " + faltante + " personas para que entren todos.");
            }
            Console.WriteLine("Personas dentro actualmente: " + PersonasActuales + "/" + AforoMaximo);
            Console.WriteLine("========================================\n");
        }
    }
}