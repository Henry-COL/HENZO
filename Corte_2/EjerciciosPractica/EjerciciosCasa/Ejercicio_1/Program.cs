using Ejercicio_1.HospitalSystem.Enums;
using Ejercicio_1.HospitalSystem.Modelos;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Creamos la lista para guardar los pacientes we
            List<Pacientes> listaPacientes = new List<Pacientes>();

            // Nombramos la carpeta padre
            string nombreCarpeta = "DatosHospital";

            // Validamos si existe, para que no de error
            if (!Directory.Exists(nombreCarpeta))
            {
                Directory.CreateDirectory(nombreCarpeta);
            }

            // Nombramos las subcarpetas que van a ir dentro de la carpeta "DatosHospital"
            string[] subCarpetas = { "Moderado", "Leve", "Grave", "MuyGrave", "Critico", "SinGravedad", "Desconocida" };

            // Validamos si existen las subcarpetas, para que no de error
            for (int i = 0; i < subCarpetas.Length; i++)
            {
                string subCarpetaPath = Path.Combine(nombreCarpeta, subCarpetas[i]);
                if (!Directory.Exists(subCarpetaPath))
                {
                    Directory.CreateDirectory(subCarpetaPath);
                }
            }

            bool continuar = true;
            Console.WriteLine("========== BIENVENIDO AL SISTEMA: HOSPITAL SYSTEM ==========");
            while (continuar)
            {
                Console.WriteLine("1. Agregar Paciente \n2. Buscar Paciente \n3. Modificar Paciente \n4. Eliminar Paciente \n0. Salir\n");
                Console.Write("Seleccione una opción: ");
                int opcion = int.Parse(Console.ReadLine());

                switch (opcion)
                {
                    case 0:
                        Console.Clear();
                        Console.Write("\nGracias por usar el programa.\nPor favor, presione enter en el espacio vacio. ");
                        Console.ReadLine();
                        continuar = false;
                        break;
                    case 1:
                        Opcion1(listaPacientes, nombreCarpeta);
                        break;
                    case 2:
                        Opcion2(listaPacientes);
                        break;

                }
            }
        }

        public static void Opcion1(List<Pacientes> listaPacientes, string nombreCarpeta)
        {
            Console.Clear();
            Console.WriteLine("========== AGREGAR PACIENTE ==========");
            Console.Write("\n¿Cuántos pacientes desea agregar?: ");
            if (!int.TryParse(Console.ReadLine(), out int PacientesAgregar)) return;

            for (int i = 1; i <= PacientesAgregar; i++)
            {
                Console.WriteLine($"\nIngrese los datos del paciente {i}:");
                Console.Write("Nombre: ");
                string nombre = Console.ReadLine();

                Console.Write("Edad: ");
                int edad = int.Parse(Console.ReadLine());

                Console.Write("Cédula: ");
                int cedula = int.Parse(Console.ReadLine());

                Console.Write("Teléfono: ");
                string telefono = Console.ReadLine();

                Console.Write("Gravedad (Moderado, Leve, Grave, MuyGrave, Critico, SinGravedad, Desconocida): ");
                string gravedadInput = Console.ReadLine();

                TipoGravedad gravedad;
                if (!Enum.TryParse(gravedadInput, true, out gravedad))
                {
                    gravedad = TipoGravedad.Desconocida;
                }

                // Creamos el nuevo paciente, lo agregamos a la lista y a la carpeta correspondiente
                Pacientes pacienteNuevo = new Pacientes(nombre, edad, cedula, telefono, gravedad);
                pacienteNuevo.Agregar(listaPacientes, nombreCarpeta);
                listaPacientes.Add(pacienteNuevo);
            }
        }

        public static void Opcion2(List<Pacientes> listaPacientes)
        {
            Console.Clear();
            Console.WriteLine("========== BUSCAR PACIENTE ==========");

        }
    }
}
