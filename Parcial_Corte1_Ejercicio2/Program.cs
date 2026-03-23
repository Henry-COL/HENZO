using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Parcial_Corte1_Ejercicio2
{
    class Program
    {
        static void Main(string[] args)
        {
            // 1. Entrada de datos (Usando System.Console directamente)
            Console.WriteLine("===== SIMULADOR DE CRÉDITO TUBANCO =====");

            Console.Write("> Monto del préstamo: $ ");
            double monto = double.Parse(Console.ReadLine());

            Console.Write("Tasa mensual (%): ");
            double tasaPorcentaje = double.Parse(Console.ReadLine());
            double i = tasaPorcentaje / 100;

            Console.Write("Plazo en meses: ");
            int n = int.Parse(Console.ReadLine());

            // 2. Cálculo manual de la potencia (1 + i)^n
            double factor = 1;
            for (int j = 0; j < n; j++)
            {
                factor = factor * (1 + i);
            }

            // 3. Cálculo de la cuota mensual fija
            double cuota = (monto * i * factor) / (factor - 1);

            // 4. Variables de control
            double saldoActual = monto;
            double acumuladoInteres = 0;
            DateTime fecha = System.DateTime.Now;

            Console.WriteLine("\n--- TABLA DE PAGOS ---");
            Console.WriteLine("Mes | Fecha | Abono Cap | Interés | Saldo");

            for (int mes = 1; mes <= n; mes++)
            {
                double interesDelMes = saldoActual * i;
                double abonoCapital = cuota - interesDelMes;
                saldoActual = saldoActual - abonoCapital;
                acumuladoInteres = acumuladoInteres + interesDelMes;

                fecha = fecha.AddMonths(1);

                // Mostramos los datos concatenando y usando System.Math
                Console.WriteLine("{0,-4} | {1,-10} | {2,10:C2} | {3,10:C2} | {4,10:C2}",
                    mes,
                    fecha.ToString("dd/MM/yyyy"),
                    abonoCapital,
                    interesDelMes,
                    Math.Abs(saldoActual));
            }

            // 5. Resumen final
            Console.WriteLine("\n-------------------------------------------");
            Console.WriteLine("Total Pagado: $" + Math.Round(monto + acumuladoInteres, 2));
            Console.WriteLine("Total de Intereses: $" + Math.Round(acumuladoInteres, 2));

            Console.ReadKey();
        }
    }
}