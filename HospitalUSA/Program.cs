using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Security.Policy;
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
            int contadorFallecidos = 0;

            List<Medicamento> medicacion = new List<Medicamento>();
            Medicamento m1 = new Medicamento("Aspirina");
            medicacion.Add(m1);
            Medicamento m2 = new Medicamento("Rinotizol");
            medicacion.Add(m2);
            Medicamento m3 = new Medicamento("Cascahueton");
            medicacion.Add(m3);
            Medicamento m4 = new Medicamento("Filecodeina");
            medicacion.Add(m4);
            Medicamento m5 = new Medicamento("Surnoretina");
            medicacion.Add(m5);

            List<Prueba> pruebas = new List<Prueba>();
            Prueba p1 = new Prueba("Rayos X");
            pruebas.Add(p1);
            Prueba p2 = new Prueba("TAC");
            pruebas.Add(p2);
            Prueba p3 = new Prueba("Medida Azucar");
            pruebas.Add(p1);
            Prueba p4 = new Prueba("Prueba Esfuerzo");
            pruebas.Add(p4);
            Prueba p5 = new Prueba("Escaner");
            pruebas.Add(p5);

            Paciente paciente = new Paciente();
            List<Paciente> pacientesList = new List<Paciente>();

            while (opcion != 0)
            {
                Console.WriteLine("Que quieres hacer?");
                Console.WriteLine("1. Introducir nombre y paciente");
                Console.WriteLine("2. Dar de alta");
                Console.WriteLine("3. Notificar deceso");
                Console.WriteLine("4. Realizar prueba");
                Console.WriteLine("5. Asignar medicamento");
                opcion = int.Parse(Console.ReadLine());
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
                        paciente = new Paciente(nombre, edad, dni, direccion);
                        
                        break;
                    case 2:
                        Console.WriteLine("A que persona le damos de alta?");
                        string alta = Console.ReadLine();
                        if (alta == paciente.getNombre)
                        {
                            pacientesList.Add(paciente);
                        }
                        else
                        {
                            Console.WriteLine("Esta persona no existe")
                        }
                        break;
                    case 3:
                        
                        Console.WriteLine("Quien es el paciente que ha fallecido?");
                        string fallecido = Console.ReadLine();
                        bool encontradoPersona = comprobarPersonas(fallecido, pacientesList)
                        if(encontradoPersona==true)
                        {
                            contadorFallecidos++;
                            paciente.setCurado(false);
                            Cuerpo cuerpo = new Cuerpo(contadorFallecidos,fallecido);
                            foreach(Paciente f in pacientesList)
                            {
                                if(f.getNombre().Equals(fallecido))
                                {
                                    pacientesList.Remove(f);
                                }
                            }
                            cuerpo.setHora(DateTime.Now.ToString("hh:mm:ss"));
                            cuerpo.setFecha(DateTime.Now.ToString("dd/MM/yyyy"))
                        }
                        else
                        {
                            Console.WriteLine("No hay ninguna persona con este nombre");
                        }
                            
                        break;
                    case 4:
                        Console.WriteLine("Prueba que quieres hacer?");
                        string comprobarP = Console.ReadLine();
                        bool encontradoP = comprobarPruebas(comprobarP, pruebas);
                        if (encontradoP == true)
                        {
                            paciente.setPruebas(pruebas);
                        }
                        else
                        {
                            Console.WriteLine("Prueba no encontrada");
                        }
                        break;
                    case 5:
                        Console.WriteLine("Que medicacion debe tomar?");
                        string comprobarM = Console.ReadLine();
                        bool encontradoM = comprobarMedicamentos(comprobarM, medicacion);
                        if (encontradoM == true)
                        {
                            paciente.setMedicacion(medicacion);
                        }
                        else
                        {
                            Console.WriteLine("Medicamento no encontrado");
                        }
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
        private static bool comprobarPruebas(string comprobarP, List<Prueba> pruebas)
        {
            foreach(var p in pruebas)
            {
                Console.WriteLine(p);
                if (comprobarP == p.ToString())
                {
                    return true;
                }
                else 
                {
                    return false;
                }
            }
            return false;
        }

        private static bool comprobarMedicamentos(string comprobarM, List<Medicamento> medicacion)
        {
            foreach(var m in medicacion)
            {
                if(comprobarM == m.ToString())
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }
            return false;
        }

        private static bool comprobarPersonas(string fallecido, List<Paciente> pacientes)
        {
            foreach(var paciente in pacientes)
            {
                if(fallecido== paciente.ToString())
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }
            return false;
        }
    }
}
