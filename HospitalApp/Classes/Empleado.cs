using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HospitalApp.Classes
{
    class Empleado : Persona
    {
        public string Departamento { get; set; }
        public double Salario { get; set; }

        public Empleado() : base()
        {
            Departamento = "";
            Salario = 0;
        }

        public Empleado(string nombre, int edad, string departamento, double salario) : base(nombre, edad)
        {
            Nombre = nombre;
            Edad = edad;
            Departamento = departamento;
            Salario = salario;
        }
    }
}
