using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibreriaEmpleado.Models
{
    public class Empleado:Persona
    {

        public int Id { get; set; }
        public string Legajo { get; set; }

        public string Departamento { get; set; }

        public Empleado(int id, string legajo, string departamento, string nombre, string apellido) : base(nombre, apellido)
        {
            Id = id;
            Legajo = legajo;
            Departamento = departamento;

        }
    }
}
