using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Net.Mime;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using HospitalApp.Classes;

namespace HospitalApp
{
    class Program
    {


        static void Main(string[] args)
        {

            var p1 = new Paciente("María Benito", 27, "Radiografía");
            var p2 = new Paciente("Daniel Ramírez", 41, "Dolor craneal");
            var p3 = new Paciente("Carlos García", 34, "Operación de corazón");

            var e1 = new Empleado("Fernando Urrea", 33, "Análisis", 1825.50);
            var e2 = new Empleado("Marta Huldín", 39, "Enfermería", 1445.25);
            var e3 = new Empleado("Guillermo Pérez", 33, "Cirujía", 2690.75);

            var lp1 = new List<Paciente> { p1, p2, p3 };
            var le1 = new List<Empleado> { e1, e2, e3 };
            var h1 = new Hospital("Hospital La Paz", le1, lp1);

            var listaHospitales = new List<Hospital> { h1 };


            var userInput = 0;

            do
            {
                userInput = Home();
                switch (userInput)
                {
                    case 0:
                        Console.WriteLine("Opción incorrecta");
                        break;
                    case 1:
                        ListadoHospitales(listaHospitales);
                        break;
                    case 2:
                        listaHospitales.Add(NuevoHospital());
                        break;
                }

            } while (userInput != 3);

        }
        public static int Home()
        {

            Console.WriteLine("Menú principal");
            Console.WriteLine("1- Listado de hospitales");
            Console.WriteLine("2- Nuevo hospital");
            Console.WriteLine("3- Salir de la aplicación");
            int n;
            int.TryParse(Console.ReadLine(), out n);


            return n;

        }

        public static Hospital NuevoHospital()
        {
            Console.Clear();
            Console.WriteLine("Escriba el nombre del nuevo hospital: ");

            var nombre = Console.ReadLine();
            var h = new Hospital(nombre, new List<Empleado>(), new List<Paciente>());

            return h;

        }

        public static void ListadoHospitales(List<Hospital> lh)
        {
            Console.Clear();
            foreach (var v in lh)
            {
                Console.WriteLine("---");
                Console.WriteLine("ID: {0}", v.ID);
                Console.WriteLine("Nombre: {0}", v.Nombre);
                Console.WriteLine("---");
            }
            Console.WriteLine();
            Console.WriteLine("Introduce");

        }


    }
}
