using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WindowsEmpleados.Models;

namespace WindowsEmpleados.Data
{
    public class DbEmpleadosContext:DbContext
    {

        public DbSet<Empleado> Empleados { get; set; }
        public DbSet<Departamento> Departamentos { get; set; }



    }
}
