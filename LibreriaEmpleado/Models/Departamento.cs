using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibreriaEmpleado.Models
{
    public class Departamento
    {

        public int ID { get; set; }
        public string Nombre { get; set; }
        public List<Empleado> Empleados { get; set; }

        public Departamento(int iD, string nombre, List<Empleado> empleados)
        {
            ID = iD;
            Nombre = nombre;
            Empleados = empleados;
        }
    }
}
