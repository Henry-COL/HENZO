using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Corte_1.Ejercicios_Basicos.EJ_Tema1.Generador_Correo
{
    public class GeneradorCorreo
    {
        public string Nombre;
        public string Apellido;
        public string EmpresaN;

        public GeneradorCorreo(string nombre, string apellido, string empresaN)
        {
            Nombre = nombre.ToLower();
            Apellido = apellido.ToLower();
            EmpresaN = empresaN.ToLower();
        }

        public void MostrarCorreo()
        {
            Console.WriteLine("\n========================================");
            Console.WriteLine("DATOS REGISTRADOS:");
            Console.WriteLine("Usuario: " + Nombre + " " + Apellido);
            Console.WriteLine("Empresa: " + EmpresaN);
            string resultado = Nombre + "." + Apellido + "@" + EmpresaN + ".com";
            Console.WriteLine("Correo generado: " + resultado);
            Console.WriteLine("========================================\n");
        }
    }
}