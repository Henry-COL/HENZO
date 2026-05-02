using app_inventario.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace app_inventario.Controller
{
    public class UsuarioController
    {
        private UsuarioModel _modelo;

        public UsuarioController(UsuarioModel modelo)
        {
            _modelo = modelo;
        }

        public bool ProcesarCompra(long valorCompra)
        {
            return _modelo.RestarSaldo(valorCompra);
        }

        public long ObtenerSaldo()
        {
            return _modelo.Saldo;
        }
    }
}
