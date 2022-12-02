using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HospitalUSA
{
    public class Paciente : Persona
    {
        private string diagnostico;
        private int diasIngreso;
        private char pronostico;
        private List<string> medicacion;
        private List<string> pruebas;
        private bool curado;

        public Paciente(string diagnostico, int diasIngreso, char pronostico, List<string> medicacion, List<string> pruebas, bool curado)
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
        public List<string> getMedicacion() { return medicacion; }
        public List<string> getPruebas() { return pruebas; }
        public bool getCurado() { return true; }
        public void setDiagnostico(string diagnostico)
        {
            this.setDiagnostico(diagnostico);
        }
        public void setDiasIngreso(int diasIngreso)
        {
            this.setDiasIngreso(diasIngreso);
        }
        public void setPronostico(char pronostico)
        {
            this.setPronostico(pronostico);
        }
        public void setMedicacion(List<string> medicacion)
        {
            this.setMedicacion(medicacion);
        }
        public void setPruebas(List<string> pruebas)
        {
            this.setPruebas(pruebas);
        }
        public void setCurado(bool curado)
        {
            this.setCurado(curado);
        }
    }
}
