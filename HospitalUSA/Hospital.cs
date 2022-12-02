using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HospitalUSA
{
    public class Hospital
    {
        private int pacientes;
        private int habitaciones;

        public Hospital(int pacientes, int habitaciones)
        {
            this.pacientes = pacientes;
            this.habitaciones = habitaciones;
        }
        public Hospital() { }

        public int getPacientes() { return pacientes; }
        public int getHabitaciones() { return habitaciones; }
        public void setPacientes(int pacientes)
        {
            this.setPacientes(pacientes);
        }
        public void setHabitaciones(int habitaciones)
        {
            this.setHabitaciones(habitaciones);
        }
    }
}
