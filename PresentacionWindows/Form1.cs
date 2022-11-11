using LibreriaEmpleado.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PresentacionWindows
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnCargarDatos_Click(object sender, EventArgs e)
        {

            Departamento departamento = new Departamento(100, "Bazar", new List<Empleado>());
            Empleado empleado1 = new Empleado(1, "AC3341", departamento.Nombre, "Juan", "Nandez");
            Empleado empleado2 = new Empleado(2, "AC3424", departamento.Nombre, "Romina", "Celer");
            Empleado empleado3 = new Empleado(3, "AC3645", departamento.Nombre, "Pedro", "Gutierrez");

            List<Empleado> empleados= new List<Empleado>();
            empleados.Add(empleado1);
            empleados.Add(empleado2);
            empleados.Add(empleado3);

            departamento.Empleados = empleados;

            gridEmpleados.DataSource = empleados;

        }
    }
}
