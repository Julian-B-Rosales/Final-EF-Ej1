using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibreriaEmpleado.Models
{
    public class Cliente:Persona
    {

        public int ID { get; set; }
        public string Cuit { get; set; }
        public string Telefono { get; set; }

        public Cliente(int iD, string cuit, string telefono, string nombre, string apellido):base(nombre, apellido)
        {
            ID = iD;
            Cuit = cuit;
            Telefono = telefono;
        }
    }
}
