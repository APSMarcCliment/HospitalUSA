using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HospitalUSA
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int opcion = 30;
            string nombre = "";
            int edad = 0;
            int dni = 0;
            string direccion = "";

            List<string> medicacion = new List<string>();
            medicacion.Add("Aspirina");
            medicacion.Add("Rinotizol");
            medicacion.Add("Cascahueton");
            medicacion.Add("Filecodeina");
            medicacion.Add("Surnoretina");
            List<string> pruebas = new List<string>();
            pruebas.Add("Rayos X");
            pruebas.Add("TAC");
            pruebas.Add("Medida Azucar");
            pruebas.Add("Prueba de esfuerzo");
            pruebas.Add("Escaner");

            //List<Paciente> nombrePacientes= new List<Paciente>();

            //Persona persona1 = new Persona("Marc", 25, 74839264, "Carrer del Gall");
            //Persona persona2 = new Persona("Xavi", 27, 79289354, "Carrer del Llastics");
            //Persona persona3 = new Persona("Laura", 18, 93846281, "Passeig de Fabra i Puig");
            //Persona persona4 = new Persona("Anna", 29, 74928629, "Carrer del Gall");

            while (opcion != 0)
            {
                Console.WriteLine("Que quieres hacer?");
                Console.WriteLine("1. Introducir nombre y paciente");
                Console.WriteLine("2. Dar de alta");
                Console.WriteLine("3. Notificar deceso");
                Console.WriteLine("4. Realizar prueba");
                Console.WriteLine("5. Asignar medicamento");
                switch (opcion)
                {
                    case 1:
                        Console.WriteLine("Nombre?");
                        nombre = Console.ReadLine();
                        Console.WriteLine("Edad?");
                        edad = int.Parse(Console.ReadLine());
                        Console.WriteLine("DNI?");
                        dni = int.Parse(Console.ReadLine()); ;
                        Console.WriteLine("Direccion?");
                        direccion = Console.ReadLine();
                        Persona persona1 = new Persona(nombre, edad, dni, direccion);
                        break;
                    case 2:
                        break;
                    case 3:
                        break;
                    case 4:
                        break;
                    case 5:
                        break;
                    case 0:
                        Console.WriteLine("Gracias por usar este programa");
                        break;
                    default:
                        Console.WriteLine("Opcion incorrecta");
                        break;
                }
            }
        }
    }
}
