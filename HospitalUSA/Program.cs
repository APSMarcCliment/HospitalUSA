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
            bool curado = true;

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
            Paciente paciente = new Paciente();
            List<Paciente> pacientesList = new List<Paciente>();
            
            Medicamento medicamento1 = new Medicamento(medicacion[0], "No uso para menores de 5 años", "Adormecimiento", 3, "Dolor de barriga", 15);
            Medicamento medicamento2 = new Medicamento(medicacion[1], "No uso para menores de 18 años", "Menor dolor de cuello", 2, "Dolor de cabeza", 10);
            Medicamento medicamento3 = new Medicamento(medicacion[2], "No uso para menores de 3 años", "Cansancio", 4, "Dolor de huesos", 11);
            Medicamento medicamento4 = new Medicamento(medicacion[3], "No uso para menores de 10 años", "Adormecimiento", 2, "Dolor de cuello", 18);
            Medicamento medicamento5 = new Medicamento(medicacion[4], "No uso para menores de 10 años", "Crecimiento del pelo", 1, "Desestabilizacion hormonal", 5);


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
                        Persona persona = new Persona(nombre, edad, dni, direccion);
                        break;
                    case 2:
                        pacientesList.Add(new Paciente());
                        break;
                    case 3:
                        paciente.setCurado(false);
                        break;
                    case 4:
                        Console.WriteLine("Prueba que quieres hacer?");
                        paciente.setPruebas(pruebas);
                        break;
                    case 5:
                        Console.WriteLine("Que medicacion debe tomar?");
                        paciente.setMedicacion(medicacion);
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
