using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HospitalUSA
{
    public class Hospital
    {
        private string nombre;
        private int pacientes;
        private int habitaciones;
        private List<Paciente> listaPacientes = new List<Paciente>();

        public Hospital(string nombre, int pacientes, int habitaciones, List<Paciente> listaPacientes)
        {
            this.nombre = nombre;
            this.pacientes = pacientes;
            this.habitaciones = habitaciones;
            this.listaPacientes = listaPacientes;
        }
        public Hospital() { }

        public string getNombre() { return nombre; }
        public int getPacientes() { return pacientes; }
        public int getHabitaciones() { return habitaciones; }
        public List<Paciente> getListaPacientes() { return listaPacientes; }
        public void setNombre(string nombre)
        {
            this.setNombre(nombre);
        }
        public void setPacientes(int pacientes)
        {
            this.setPacientes(pacientes);
        }
        public void setHabitaciones(int habitaciones)
        {
            this.setHabitaciones(habitaciones);
        }
        public void setListaPacientes(List<Paciente> listaPacientes)
        {
            this.setListaPacientes(listaPacientes);
        }
    }
}
