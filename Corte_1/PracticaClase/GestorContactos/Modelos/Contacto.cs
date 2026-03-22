using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GestorContactos.Modelos
{
    public class Contacto
    {
            public string Nombre { get; set; }
            public string Telefono { get; set; }
            public string Correo { get; set; }

            // Método solicitado para el formato CSV
            public string ToCSV()
            {
                return $"{Nombre};{Telefono};{Correo}";
            }
        }
    }
}
