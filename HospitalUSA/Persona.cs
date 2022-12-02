using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HospitalUSA
{
    public class Persona
    {
        private string nombre;
        private int edad;

        public Persona(string nombre, int edad)
        {
            this.nombre = nombre;
            this.edad = edad;
        }

        public Persona() { }

        public string getNombre() { return nombre; }
        public int getEdad() { return edad;}
        public void setNombre(string nombre)
        {
            this.setNombre(nombre);
        }
        public void setEdad(int edad)
        {
            this.setEdad(edad);
        }
    }
    
    

}
