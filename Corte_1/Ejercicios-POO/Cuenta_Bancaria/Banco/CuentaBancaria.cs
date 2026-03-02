using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cuenta_Bancaria.Banco
{
    public class CuentaBancaria
    {
        public string Titlar;
        protected double Saldo;

        public CuentaBancaria(string titular, double saldoInicial)
        {
            this.Titlar = titular;
            this.Saldo = saldoInicial;
        }

        public double ObtenerSaldo()
        {
            return Saldo;
        }

        public virtual void MostrarDetalles()
        {
            Console.Clear();
            Console.WriteLine("====== Detalles de la Cuenta Bancaria =====");
            Console.WriteLine("Titular de la cuenta bancaria: " + Titlar);
            Console.WriteLine("Saldo disponible: $ " + Saldo);
            Console.Write("\nPor favor, para continuar, presiona Enter...");
            Console.ReadLine();
            Console.Clear();
        }
    }
}