using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cuenta_Bancaria.Banco
{
    public class Retirar : CuentaBancaria
    {
        public double CantidadARetirar;

        public Retirar(string titular, double saldoInicial, double cantidadARetirar) : base(titular, saldoInicial)
        {
            this.CantidadARetirar = cantidadARetirar;
        }

        public void HacerRetiro()
        {
            if (this.CantidadARetirar <= Saldo && this.CantidadARetirar > 0)
            {
                Console.Clear();
                this.Saldo -= this.CantidadARetirar;
                Console.WriteLine($"==== Retiro realizado ====\"");
                Console.WriteLine($"Titular: {Titlar}");
                Console.WriteLine($"Se retiraron: ${this.CantidadARetirar}");
                Console.WriteLine($"Saldo restante: ${Saldo}");
                Console.Write("\nPor favor, para continuar, presiona Enter...");
                Console.ReadLine();
                Console.Clear();
            }
            else
            {
                Console.WriteLine("\nERROR: Fondos insuficientes para retirar $" + this.CantidadARetirar);
                Console.Write("\nPor favor, para continuar, presiona Enter...");
                Console.ReadLine();
                Console.Clear();
            }
        }
    }
}