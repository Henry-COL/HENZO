using Ejercicio_1.HospitalSystem.Enums;
using Ejercicio_1.HospitalSystem.Interfaces;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_1.HospitalSystem.Modelos
{
    public class Pacientes : IHospital
    {
        string Nombre_Paciente { get; set; }
        int edad_paciente { get; set; }
        int cedula_paciente { get; set; }
        string telefono_paciente { get; set; }
        TipoGravedad gravedad_paciente { get; set; }

        public Pacientes(string nombre, int edad, int cedula_paciente,string telefono_paciente, TipoGravedad gravedad)
        {
            this.Nombre_Paciente = nombre;
            this.edad_paciente = edad;
            this.cedula_paciente = cedula_paciente;
            this.telefono_paciente = telefono_paciente ;
            this.gravedad_paciente = gravedad;
        }

        public double TotalPagar()
        {
            double pagar = 0;

            switch (gravedad_paciente)
            {
                case TipoGravedad.Moderado:
                    pagar = 5000;
                    break;
                case TipoGravedad.Leve:
                    pagar = 2000;
                    break;
                case TipoGravedad.Grave:
                    pagar = 10000;
                    break;
                case TipoGravedad.MuyGrave:
                    pagar = 15000;
                    break;
                case TipoGravedad.Critico:
                    pagar = 20000;
                    break;
                case TipoGravedad.SinGravedad:
                    pagar = 1000;
                    break;
                case TipoGravedad.Desconocida:
                    pagar = 3000;
                    break;
            }
            return pagar;

        }



        public string Factura()
        {
            Console.WriteLine("========== FACTURA DEL PACIENTE ==========");
            string fechaActual = DateTime.Now.ToString("dd/MM/yyyy hh:mm tt");

            string datos = $"Fecha de Registro: {fechaActual}\n";
            datos += $"Paciente: {Nombre_Paciente}\n";
            datos += $"Edad: {edad_paciente}\n";
            datos += $"Cedula: {cedula_paciente}\n";
            datos += $"Telefono: {telefono_paciente}\n";
            datos += $"Gravedad: {gravedad_paciente}\n";
            datos += $"\nTotal a Pagar: ${TotalPagar()}\n";

            return datos;
        }

        public void Agregar(List<Pacientes> listaPacientes, string nombreCarpeta)
        {
            // Usar las propiedades correctas definidas en la clase
            string rutaSubcarpeta = Path.Combine(nombreCarpeta, this.gravedad_paciente.ToString());

            // Si la carpeta de la gravedad no existe, hay que crearla para evitar errores
            if (!Directory.Exists(rutaSubcarpeta))
            {
                Directory.CreateDirectory(rutaSubcarpeta);
            }

            string nombreArchivo = $"{this.Nombre_Paciente}.txt";
            string rutaArchivo = Path.Combine(rutaSubcarpeta, nombreArchivo);

            // Guardado: escribir la factura del paciente actual
            using (StreamWriter escritor = new StreamWriter(rutaArchivo))
            {
                escritor.WriteLine(this.Factura());
            }

            Console.WriteLine($"¡Datos de {this.Nombre_Paciente} guardados en la carpeta {this.gravedad_paciente}!");
        }

        // Busca un paciente en la lista por cédula y muestra su factura si lo encuentra
        public void Buscar(List<Pacientes> listaPacientes)
        {
            if (listaPacientes == null || listaPacientes.Count == 0)
            {
                Console.WriteLine("No hay pacientes registrados.");
                return;
            }

            Console.Write("Ingrese la cédula del paciente a buscar: ");
            if (!int.TryParse(Console.ReadLine(), out int cedulaBuscar))
            {
                Console.WriteLine("Cédula no válida.");
                return;
            }

            Pacientes encontrado = listaPacientes.FirstOrDefault(p => p.cedula_paciente == cedulaBuscar);
            if (encontrado == null)
            {
                Console.WriteLine($"No se encontró ningún paciente con cédula {cedulaBuscar}.");
                return;
            }

            Console.WriteLine("--- Paciente encontrado ---");
            Console.WriteLine(encontrado.Factura());
        }
    }
}
