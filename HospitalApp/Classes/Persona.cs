using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HospitalApp.Classes
{
    class Persona
    {
        public int ID { get; set; }
        public string Nombre { get; set; }
        public int Edad { get; set; }

        protected Persona()
        {
            Random r = new Random();
            ID = r.Next(1000, 9999);
            Nombre = "";
            Edad = 0;
        }

        protected Persona(string nombre, int edad)
        {
            Random r = new Random();
            ID = r.Next(1000, 9999);
            Nombre = nombre;
            Edad = edad;
        }

    }
}
