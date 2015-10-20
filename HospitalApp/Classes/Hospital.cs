using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HospitalApp.Classes
{
    class Hospital
    {
        public int ID { get; set; }
        public string Nombre { get; set; }
        public List<Empleado> Empleados { get; set; }
        public List<Paciente> Pacientes { get; set; }

        public Hospital()
        {
            Random r = new Random();
            ID = r.Next(1000, 9999);
            Nombre = "";
            Empleados = new List<Empleado>();
            Pacientes = new List<Paciente>();
        }

        public Hospital(string nombre, List<Empleado> empleados, List<Paciente> pacientes)
        {
            Random r = new Random();
            ID = r.Next(1000, 9999);
            Nombre = nombre;
            Empleados = empleados;
            Pacientes = pacientes;
        }

    }
}
