using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Cuenta_Bancaria.Banco;

class Program
{
    static void Main()
    {
        Console.WriteLine("==== Bienvenido al Sistema Bancario ====");
        Console.Write("Ingrese el nombre del titular: ");
        string nombre = Console.ReadLine();
        Console.Write("Ingrese su saldo inicial: ");
        double saldoActual = double.Parse(Console.ReadLine());
        bool continuar = true;
        Console.WriteLine("Cuenta creada para: " + nombre + " con saldo inicial de $" + saldoActual);
        Console.Write("\nPor favor, para continuar, presiona Enter...");
        Console.ReadLine();
        Console.Clear();

        while (continuar)
        {
            Console.WriteLine("==== Menú Bancario ====");
            Console.WriteLine("1. Retirar dinero");
            Console.WriteLine("2. Depositar dinero");
            Console.WriteLine("3. Mostrar detalles de la cuenta");
            Console.WriteLine("4. Salir");
            Console.Write("\nSeleccione una opción: ");
            string opcion = Console.ReadLine();

            switch (opcion)
            {
                case "1":
                    Console.Clear();
                    Console.Write("¿Cuánto desea retirar?: ");
                    if (double.TryParse(Console.ReadLine(), out double montoRetiro))
                    {
                        Retirar tRetiro = new Retirar(nombre, saldoActual, montoRetiro);
                        tRetiro.HacerRetiro();
                        saldoActual = tRetiro.ObtenerSaldo();
                    }
                    break;

                case "2":
                    Console.Clear();
                    Console.Write("¿Cuánto desea depositar?: ");
                    if (double.TryParse(Console.ReadLine(), out double montoDeposito))
                    {
                        Depositar tDeposito = new Depositar(nombre, saldoActual, montoDeposito);
                        tDeposito.HacerDeposito();
                        saldoActual = tDeposito.ObtenerSaldo();
                    }
                    break;

                case "3":
                    Console.Clear();
                    CuentaBancaria cuenta = new CuentaBancaria(nombre, saldoActual);
                    cuenta.MostrarDetalles();
                    break;

                case "4":
                    Console.Clear();
                    continuar = false;
                    Console.WriteLine("\nSaliendo del sistema...");
                    break;

                default:
                    Console.WriteLine("\nOpción no válida.");
                    break;
            }
        }
    }
}