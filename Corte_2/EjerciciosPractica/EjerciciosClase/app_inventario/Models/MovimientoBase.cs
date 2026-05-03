using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace app_inventario.Models
{
    public class MovimientoBase
    {
        public string Fecha { get; set; }
        public string Codigo { get; set; }
        public string Titulo { get; set; }
        public string Cantidad { get; set; }
        public string Observacion { get; set; }
    }
}