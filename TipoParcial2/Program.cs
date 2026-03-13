using System;
using System.Collections.Generic;
using System.Linq; //
using System.Security.Cryptography.X509Certificates; //
using System.Text; //
using System.Threading.Tasks; //
using TipoParcial2.ConcesionarioVehiculos.Modelos;
using TipoParcial2.ConcesionarioVehiculos.Interfaces;
using TipoParcial2.ConcesionarioVehiculos.Enumns;

namespace ConcesionarioVehiculos
{
    class Program
    {
        static void Main(string[] args)
        {
            List<IVendible> ventas = new List<IVendible>();
            bool continuar = true;

            while (continuar)
            {
                Console.Clear();
                Console.WriteLine("========================================");
                Console.WriteLine("       CONCESIONARIO MULTIMARCA         ");
                Console.WriteLine("========================================");
                Console.WriteLine(" 1. [ + ] Registrar Auto");
                Console.WriteLine(" 2. [ + ] Registrar Motocicleta");
                Console.WriteLine(" 3. [ + ] Registrar Camión");
                Console.WriteLine(" 4. [ v ] Ver Reporte de Facturas");
                Console.WriteLine(" 5. [ x ] Salir");
                Console.WriteLine("========================================");
                Console.Write(" Seleccione una opción: ");

                string opcion = Console.ReadLine();

                if (opcion == "5") { continuar = false; continue; }
                if (opcion == "4")
                {
                    MostrarReporteFinal(ventas);
                    continue;
                }

                if (opcion == "1" || opcion == "2" || opcion == "3")
                {
                    Console.Clear();
                    string titulo = opcion == "1" ? "AUTO" : opcion == "2" ? "MOTOCICLETA" : "CAMIÓN";
                    Console.WriteLine($"==== REGISTRAR NUEVO {titulo} ====\n");

                    // Usamos try-catch por si el usuario escribe letras en lugar de números
                    try
                    {
                        Console.Write(" > ID: "); string id = Console.ReadLine();
                        Console.Write(" > Marca: "); string marca = Console.ReadLine();
                        Console.Write(" > Modelo: "); string modelo = Console.ReadLine();
                        Console.Write(" > Año: "); int year = int.Parse(Console.ReadLine());
                        Console.Write(" > Precio Base: "); decimal precio = decimal.Parse(Console.ReadLine());

                        Console.WriteLine("\n--- Configuraciones Técnicas ---");
                        Console.Write(" > Combustible (Gasolina/Diesel/Electrico/Hibrido): ");
                        TipoCombustible combustible = (TipoCombustible)Enum.Parse(typeof(TipoCombustible), Console.ReadLine(), true);

                        Console.Write(" > Estado (Nuevo/Usado/Seminuevo): ");
                        EstadoVehiculo estado = (EstadoVehiculo)Enum.Parse(typeof(EstadoVehiculo), Console.ReadLine(), true);

                        switch (opcion)
                        {
                            case "1":
                                Console.WriteLine("\n--- Detalles de Auto ---");
                                Console.Write(" > Número de puertas: "); int puertas = int.Parse(Console.ReadLine());
                                Console.Write(" > ¿Tiene Aire Acondicionado? (si/no): ");
                                bool aire = Console.ReadLine().ToLower() == "si";
                                ventas.Add(new Auto(id, marca, modelo, year, precio, combustible, estado, puertas, aire));
                                break;

                            case "2":
                                Console.WriteLine("\n--- Detalles de Motocicleta ---");
                                Console.Write(" > Cilindraje (CC): "); int cc = int.Parse(Console.ReadLine());
                                Console.Write(" > ¿Es deportiva? (si/no): ");
                                bool deportiva = Console.ReadLine().ToLower() == "si";
                                ventas.Add(new Motocicleta(id, marca, modelo, year, precio, combustible, estado, cc, deportiva));
                                break;

                            case "3":
                                Console.WriteLine("\n--- Detalles de Camión ---");
                                Console.Write(" > Capacidad Carga (Ton): "); decimal carga = decimal.Parse(Console.ReadLine());
                                Console.Write(" > Número de ejes: "); int ejes = int.Parse(Console.ReadLine());
                                ventas.Add(new Camion(id, marca, modelo, year, precio, combustible, estado, carga, ejes));
                                break;
                        }

                        Console.WriteLine($"\n[OK] {titulo} registrado con éxito.");
                    }
                    catch (Exception ex)
                    {
                        Console.WriteLine($"\n[ERROR] Datos incorrectos: {ex.Message}");
                    }
                    
                    Console.WriteLine("Presione cualquier tecla para volver al menú...");
                    Console.ReadKey();
                }
            }
        }

        static void MostrarReporteFinal(List<IVendible> ventas)
        {
            Console.Clear();
            Console.WriteLine("========================================");
            Console.WriteLine("       REPORTE DE VENTAS TOTALES        ");
            Console.WriteLine("========================================\n");

            if (ventas.Count == 0)
            {
                Console.WriteLine(" No hay vehículos registrados aún.");
            }
            else
            {
                foreach (var v in ventas)
                {
                    v.GenerarFacturaVenta();
                    Console.WriteLine("----------------------------------------");
                }
            }

            Console.WriteLine("\nFin del reporte. Presione una tecla para volver.");
            Console.ReadKey();
        }
    }
}