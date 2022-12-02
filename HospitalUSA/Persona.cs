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
        private int dni;
        private string direccion;

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
            this.setNombre(nombre);
        }
        public void setEdad(int edad)
        {
            this.setEdad(edad);
        }
        public void setDni(int dni)
        {
            this.setDni(dni);
        }
        public void setDireccion(string direccion)
        {
            this.setDireccion(direccion);
        }
    }
    
    

}
