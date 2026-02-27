using Corte_1.Ejercicios_Basicos.App_Musica;
using Corte_1.Ejercicios_Basicos.EJ_Tema1.Aforo;
using Corte_1.Ejercicios_Basicos.EJ_Tema1.Generador_Correo;
using Corte_1.Ejercicios_Basicos.EJ_Tema1.Pefil_Gamer;
using Corte_1.Ejercicios_Basicos.EJ_Tema1.Propina;
using Corte_1.Ejercicios_Basicos.EJ_Tema1.Simulador_Semaforo;
using Corte_1.Ejercicios_Basicos.Inventario;
using Corte_1.Ejercicios_Basicos.Sistema_Mascotas;
using Corte_1.Ejercicios_Basicos.Sitema_Biblioteca;
using Corte_1.Ejercicios_Basicos.Vehiculos_Electricos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Corte_1
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            bool continuar = true;

            while (continuar)
            {
                Console.Clear();
                Console.WriteLine("===== SISTEMA DE EJERCICIOS BÁSICOS =====");
                Console.WriteLine("TEMA 1:");
                Console.WriteLine("1. Perfil Gamer.");
                Console.WriteLine("2. Calculadora Propina Solidaria.");
                Console.WriteLine("3. Control de Aforo.");
                Console.WriteLine("4. Generador de Correo.");
                Console.WriteLine("5. Simulador Semaforo");
                Console.WriteLine("\nTEMA 2:");
                Console.WriteLine("6. Mascota Virtual.");
                Console.WriteLine("7. Inventario de Tienda.");
                Console.WriteLine("8. Aplicación de Streaming.");
                Console.WriteLine("9. Sistema de Biblioteca.");
                Console.WriteLine("10. Vehículo Eléctrico.");
                Console.WriteLine("\n0. Salir.");

                Console.Write("\nSeleccione una opción: ");

                if (!int.TryParse(Console.ReadLine(), out int opcion)) continue;
                Console.Clear();

                switch (opcion)
                {
                    case 1:
                        Console.WriteLine(">>> EJERCICIO 1: PERFIL GAMER <<<");
                        Console.Write("Nickname: ");
                        string nick = Console.ReadLine();
                        Console.Write("Nivel (1-100): ");
                        int lvl = int.Parse(Console.ReadLine());
                        Console.Write("Suscripcion Premium? (1. Si / 2. No): ");
                        bool esVip = Console.ReadLine() == "1";

                        Perfil_Gamer perfil = new Perfil_Gamer(nick, lvl, esVip);
                        perfil.MostrarBienvenida();
                        break;
                    case 2:
                        Console.WriteLine(">>> EJERCICIO 2: CALCULADORA DE PROPINA SOLIDARIA <<<");
                        Console.Write("Total de la cuenta: $ ");
                        double total = double.Parse(Console.ReadLine());
                        Console.Write("Porcentaje de propina (0-100): ");
                        int porcentaje = int.Parse(Console.ReadLine());
                        CalculadoraPropina calculadora = new CalculadoraPropina(total, porcentaje);
                        calculadora.CalcularYMostrar();
                        break;
                    case 3:
                        Console.WriteLine(">>> EJERCICIO 3: CONTROL DE AFORO <<<");

                        Console.Write("¿Con cuantas personas inicia la discoteca?: ");
                        int inicio = int.Parse(Console.ReadLine());
                        ControlAforo sistemaAforo = new ControlAforo(inicio);

                        bool seguirAforo = true;
                        while (seguirAforo)
                        {
                            Console.Write("¿Cuantas personas quieren entrar? (O pulse 0 para volver al menu): ");
                            int quieren = int.Parse(Console.ReadLine());

                            if (quieren == 0)
                            {
                                seguirAforo = false;
                            }
                            else
                            {
                                sistemaAforo.ValidarIngreso(quieren);
                            }
                        }
                        break;
                    case 4:
                        Console.WriteLine(">>> EJERCICIO 4: GENERADOR DE CORREO <<<");
                        Console.Write("Nombre: ");
                        string nom = Console.ReadLine();

                        Console.Write("Apellido: ");
                        string ape = Console.ReadLine();

                        Console.Write("Nombre de la empresa: ");
                        string emp = Console.ReadLine();

                        GeneradorCorreo correo = new GeneradorCorreo(nom, ape, emp);
                        correo.MostrarCorreo();
                        break;
                    case 5:
                        Console.WriteLine(">>> EJERCICIO 5: SIMULADOR DE SEMAFORO <<<");

                        Console.Write("Ingrese el color actual (Verde, Amarillo, Rojo): ");
                        string colorIngresado = Console.ReadLine();

                        SemaforoInteligente miSemaforo = new SemaforoInteligente(colorIngresado);
                        miSemaforo.MostrarAccion();
                        break;
                    case 6:
                        Console.WriteLine(">>> EJERCICIO 6: MASCOTA VIRTUAL <<<");
                        Mascota mascota = new Mascota();
                        mascota.MostrarMascotas();
                        break;

                    case 7:
                        Console.WriteLine(">>> EJERCICIO 7: INVENTARIO <<<");
                        Producto producto = new Producto("Smartphone Galaxy", 850000, 15);
                        Console.WriteLine($"Producto: {producto.Nombre}\nPrecio: ${producto.Precio_Producto}\nStock: {producto.Cantidad_Stock}");
                        Console.Write("\nCantidad a comprar: ");
                        producto.Cantidad = int.Parse(Console.ReadLine());
                        producto.VenderProducto();
                        break;

                    case 8:
                        Console.WriteLine(">>> EJERCICIO 8: STREAMING <<<");
                        List<IReproductor> biblioteca = new List<IReproductor>
                        {
                            new Cancion("Bohemian Rhapsody", "Queen"),
                            new Podcast("Psicología Al Desnudo", "Marina Mammoliti"),
                            new Cancion("Blinding Lights", "The Weeknd")
                        };

                        for (int i = 0; i < biblioteca.Count; i++)
                            Console.WriteLine($"{i}. [{biblioteca[i].GetType().Name}] {biblioteca[i].Titulo}");

                        Console.Write("\nÍndice a reproducir: ");
                        int eleccion = int.Parse(Console.ReadLine());
                        if (eleccion >= 0 && eleccion < biblioteca.Count)
                            biblioteca[eleccion].Play();
                        break;

                    case 9:
                        Console.WriteLine(">>> EJERCICIO 9: BIBLIOTECA <<<");
                        Libro libro = new Libro("El Principito");
                        Console.WriteLine($"Libro: {libro.titulo} | Estado: {(libro.disponible ? "Disponible" : "Prestado")}");
                        libro.Prestar();
                        break;

                    case 10:
                        Console.WriteLine(">>> EJERCICIO 10: VEHÍCULO ELÉCTRICO <<<");
                        VehiculoElectrico miCoche = new VehiculoElectrico("Porsche Taycan", 100);
                        Console.WriteLine($"Modelo: {miCoche.modelo} | Carga: {miCoche.bateria}%");
                        Console.Write("\nDistancia del viaje (km): ");
                        int km = int.Parse(Console.ReadLine());
                        miCoche.Viajar(km);
                        break;

                    case 0:
                        continuar = false;
                        Console.WriteLine("Saliendo del sistema...");
                        break;

                    default:
                        Console.WriteLine("Opción no válida o aún no implementada.");
                        break;
                }

                if (opcion != 0)
                {
                    Console.WriteLine("\nPresione cualquier tecla para volver al menú...");
                    Console.ReadKey();
                }
            }
        }
    }
}