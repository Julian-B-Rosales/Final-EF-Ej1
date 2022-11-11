using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WindowsEmpleados.Models;

namespace WindowsEmpleados
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        AdminEmpleado adminEmpleado = new AdminEmpleado();

        private void btnAgregar_Click(object sender, EventArgs e)
        {

            Departamento departamento = new Departamento()
            {
                Id = 1,
                Nombre = "Bazar",
                Empleados = new List<Empleado>()
            };
            adminEmpleado.Insertar(new Empleado() { Id = 2, DepartamentoId = 1, Legajo = "AC3341", Departamento = departamento, Nombre = "Juan", Apellido = "Perez" });
            adminEmpleado.Insertar(new Empleado() { Id = 3, DepartamentoId = 1, Legajo = "AC3424", Departamento = departamento, Nombre = "Romina", Apellido = "Celer" });
            adminEmpleado.Insertar(new Empleado() { Id = 4, DepartamentoId = 1, Legajo = "AC3645", Departamento = departamento, Nombre = "Pedro", Apellido = "Gutierrez" });


            


        }

        private void btnListar_Click(object sender, EventArgs e)
        {
            gridEmpleados.DataSource = adminEmpleado.Listar();
        }
    }
}
