using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HospitalUSA
{
    public class Cuerpo
    {

        private int id = 0;
        private string nombre = "";
        public Cuerpo(int id, string nombre)
        {
            this.id = id;
            this.nombre = nombre;
        }

        public Cuerpo() { }
        public int getId() { return id; }
        public string getNombre() { return nombre; }
        public void setId(int id) 
        { 
            this.id = id;
        }
        public void setNombre(string nombre)
        {
            this.nombre = nombre;
        }
    }
}
