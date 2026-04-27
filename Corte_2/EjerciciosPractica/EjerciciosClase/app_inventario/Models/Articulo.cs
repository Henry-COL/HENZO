using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace app_inventario.Models
{
    public class Articulo
    {
        public string Codigo { get; set; }
        public string Titulo { get; set; }
        public string Artistas { get; set; }
        public string TipoArticulo { get; set; }
        public string RutaPortada { get; set; }
        public int Cantidad { get; set; }
        public decimal Precio { get; set; }
    }
}
