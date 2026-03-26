using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Act1._5
{
    public class Alumno
    {
        private int DNI;
        private string nombre;
        private double cantidadFaltas;
        public Alumno (int DNI, string nombre) 
        {
          this.DNI = DNI;
          this.nombre = nombre;
          this.cantidadFaltas = 0;
        }
        public int devolverDNI () 
        {
            return DNI;
        }
        public double devolverFaltas ()
        {
            return cantidadFaltas;
        }
        public double agregarFalta (double falta)
        {
          cantidadFaltas = cantidadFaltas + falta;
          return cantidadFaltas;
        }
        public void mostrarDatos ()
        {
            System.Console.WriteLine($"DNI: {DNI}, nombre {nombre}, faltas: {cantidadFaltas}");
        }
        public double mostrarFaltas ()
        {
            return cantidadFaltas;
        }
    }
}