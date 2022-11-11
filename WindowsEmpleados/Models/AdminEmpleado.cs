using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WindowsEmpleados.Data;
using WindowsEmpleados.Models;

namespace WindowsEmpleados.Models
{
    public class AdminEmpleado
    {

        DbEmpleadosContext context = new DbEmpleadosContext();

        public void Insertar(Empleado empleado)
        {
            context.Empleados.Add(empleado);

            context.SaveChanges();
        }

        public List<Empleado> Listar()
        {
            List<Empleado> empleados = context.Empleados.ToList();

            return empleados;
        } 

    }
}
