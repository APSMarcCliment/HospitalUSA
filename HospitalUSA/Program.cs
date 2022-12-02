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
            List<Paciente> nombrePacientes= new List<Paciente>();
            nombrePacientes.Add(new Paciente());

            Persona persona1 = new Persona("Marc", 25, 74839264, "Carrer del Gall");
            Persona persona2 = new Persona("Xavi", 27, 79289354, "Carrer del Llastics");
            Persona persona3 = new Persona("Laura", 18, 93846281, "Passeig de Fabra i Puig");
            Persona persona4 = new Persona("Anna", 29, 74928629, "Carrer del Gall");

            
        }
    }
}
