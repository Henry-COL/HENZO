using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Corte_1.Ejercicios_Basicos.EJ_Tema1.Pefil_Gamer
{
    public class Perfil_Gamer
    {
        public string Nickname;
        public int Nivel;
        public bool EsPremium;

        public Perfil_Gamer(string nickname, int nivel, bool esPremium)
        {
            Nickname = nickname;
            Nivel = nivel;
            EsPremium = esPremium;
        }

        public void MostrarBienvenida()
        {
            Console.WriteLine("\n========================================");
            Console.WriteLine("¡Bienvenido, " + Nickname + "!");
            Console.WriteLine("Nivel: " + Nivel);

            if (EsPremium)
            {
                Console.WriteLine("Estado: Usuario Premium");
            }
            else
            {
                Console.WriteLine("Estado: Usuario Standard");
            }
            Console.WriteLine("========================================\n");
        }
    }
}
