using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HospitalUSA
{
    public class Paciente : Persona
    {
        private string diagnostico = "";
        private int diasIngreso = 0;
        private char pronostico;
        private List<Medicamento> medicacion;
        private List<Prueba> pruebas;
        private bool curado = true;
        private string nombre = "";
        private int edad = 0;
        private int dni = 0;
        private string direccion = "";

        public Paciente(string nombreParam, int edadParam, int dniP, string direccionP)
        {
            nombre = nombreParam;
            edad = edadParam;
            dni = dniP;
            direccion = direccionP;
            //todo
            
        }
        public Paciente(string diagnostico, int diasIngreso, char pronostico, List<Medicamento> medicacion, List<Prueba> pruebas, bool curado)
        {
            this.diagnostico = diagnostico;
            this.diasIngreso= diasIngreso;
            this.pronostico= pronostico;
            this.medicacion= medicacion;
            this.pruebas= pruebas;
            this.curado= curado;
        }
        public Paciente() { }

        public string getDiagnostico() { return diagnostico; }
        public int getDiasIngreso() { return diasIngreso; }
        public char getPronostico() { return pronostico; }
        public List<Medicamento> getMedicacion() { return medicacion; }
        public List<Prueba> getPruebas() { return pruebas; }
        public bool getCurado() { return true; }
        public void setDiagnostico(string diagnostico)
        {   
            this.diagnostico = diagnostico;
        }
        public void setDiasIngreso(int diasIngreso)
        {
            this.diasIngreso = diasIngreso;
        }
        public void setPronostico(char pronostico)
        {
            this.pronostico = pronostico;
        }
        public void setMedicacion(List<Medicamento> medicacion)
        {
            this.medicacion = medicacion;

        }
        public void setPruebas(List<Prueba> pruebas)
        {
            
            this.pruebas = pruebas;
        }
        public void setCurado(bool curado)
        {
            this.curado = curado;
        }
    }
}
