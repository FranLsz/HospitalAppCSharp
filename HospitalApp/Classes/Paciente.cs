using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HospitalApp.Classes
{
    class Paciente : Persona
    {
        public string Causa { get; set; }
        public string FechaDeAlta { get; private set; }

        public Paciente() : base()
        {
            Causa = "";
            FechaDeAlta = "";
        }

        public Paciente(string nombre, int edad, string causa) : base(nombre, edad)
        {
            Nombre = nombre;
            Edad = edad;
            Causa = causa;
            FechaDeAlta = DateTime.Now.ToShortDateString();
        }

        public string Detalles()
        {

            return "\n------\nPaciente: " + Nombre + "\nFecha de alta: " + FechaDeAlta + "\nCausa: " + Causa+"\n------";
        }

    }
}
