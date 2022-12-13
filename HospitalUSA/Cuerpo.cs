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
        var fecha;
        var hora;

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

        public void setHora(var hora)
        {
            this.hora = hora;
        }

        public void setFecha(var fecha)
        {
            this.fecha = fecha;
        }
    }
}
