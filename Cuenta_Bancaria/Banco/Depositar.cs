using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace Cuenta_Bancaria.Banco
{
    public class Depositar : CuentaBancaria
    {
        public double MontoADepositar;

        // El constructor recibe los datos y los envía al padre con 'base'
        public Depositar(string titular, double saldoInicial, double montoADepositar) : base(titular, saldoInicial)
        {
            this.MontoADepositar = montoADepositar;
        }

        public void HacerDeposito()
        {
            if (MontoADepositar > 0)
            {
                Console.Clear();
                this.Saldo += MontoADepositar;
                Console.WriteLine("==== Deposito realizado ====");
                Console.WriteLine("Titular: " + Titlar);
                Console.WriteLine("Monto sumado: $" + MontoADepositar);
                Console.WriteLine("Saldo Actualizado: $" + Saldo);
                Console.Write("\nPor favor, para continuar, presiona Enter...");
                Console.ReadLine();
                Console.Clear();
            }
            else
            {
                Console.WriteLine("\nError: El monto debe ser mayor a cero.");
            }
        }
    }
}