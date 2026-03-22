using Ejercicio_1.HospitalSystem.Modelos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_1.HospitalSystem.Interfaces
{
    internal interface IHospital
    {
        double TotalPagar();
        void Buscar(List<Pacientes> listaPacientes);
        void Agregar(List<Pacientes> listaPacientes, string nombreCarpeta);
        string Factura();
    }
}
