using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HospitalUSA
{
    public class Persona
    {
        private string nombre = "";
        private int edad = 0;
        private int dni = 0;
        private string direccion = "";

        public Persona(string nombre, int edad, int dni, string direccion)
        {
            this.nombre = nombre;
            this.edad = edad;
            this.dni = dni;
            this.direccion = direccion;
        }

        public Persona() { }

        public string getNombre() { return nombre; }
        public int getEdad() { return edad;}
        public int getDni() { return dni;}
        public string getDireccion() { return direccion;}
        public void setNombre(string nombre)
        {
            this.nombre = nombre;
        }
        public void setEdad(int edad)
        {
            this.edad = edad;
        }
        public void setDni(int dni)
        {
            this.dni = dni;
        }
        public void setDireccion(string direccion)
        {
            this.direccion = direccion;
        }
    }
    
    

}
