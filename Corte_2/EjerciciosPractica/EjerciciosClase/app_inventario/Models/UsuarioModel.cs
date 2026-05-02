using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace app_inventario.Models
{
    public class UsuarioModel
    {
        public long Saldo { get; set; }

        public bool RestarSaldo(long valorCompra)
        {
            if (Saldo < valorCompra)
                return false;

            Saldo -= valorCompra;
            return true;
        }
    }
}
