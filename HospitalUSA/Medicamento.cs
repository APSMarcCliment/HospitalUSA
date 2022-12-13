using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HospitalUSA
{
    public class Medicamento
    {
        private string nombre = "";
        private string indicaciones = "";
        private string ef_secundarios = "";
        private int dosis = 0;
        private string ef_adversos = "";
        private int precio = 0;

        public Medicamento(string nombre)
        {
            this.nombre = nombre;
        }

        public Medicamento() { }

        public string getNombre() { return nombre;}
        public string getIndicaciones() { return indicaciones;}
        public string getEf_secundarios() { return ef_secundarios;}
        public int getDosis() { return dosis;}
        public string getEf_adversos() { return ef_adversos; }
        public int getPrecio() { return precio;}
        public void setNombre(string nombre)
        {
            this.nombre = nombre;
        }
        public void setIndicaciones(string indicaciones)
        {
            this.indicaciones=indicaciones;
        }
        public void setEf_secundarios(string ef_secundarios)
        {
            this.ef_secundarios=ef_secundarios;
        }
        public void setDosis(int dosis)
        {
            this.dosis = dosis;
        }
        public void setEf_adversos(string ef_adversos)
        {
            this.ef_adversos=ef_adversos;
        }
        public void setPrecio(int precio)
        {
            this.precio = precio;
        }
    }
}
