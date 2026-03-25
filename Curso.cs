using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Act1._5
{
    public class Curso
    {
        private List <Alumno> curso;
        private Dictionary <int,Alumno> dicAlumnos;
        public Curso ()
        {
             this.dicAlumnos = new <Dictionary>();
        }
        public bool agregarAlumno(string nombre, int DNI)
        {
            bool agregado = false;
            Alumno a = new Alumno (DNI, nombre);
            if (this.buscarAlumno(DNI)== null) 
            {
              curso.Add(a);
              agregado = true;
            }
            else 
            {
                System.Console.WriteLine("El alumno ya existe");
            }
            return agregado;
        }
        public Alumno buscarAlumno (int DNI)
        {
          foreach(int )
         
        }
        public void agregarFalta (int DNI, double falta)
        {
            if (this.buscarAlumno(DNI) != null)
            {
              int i = 0;
              while (i<this.curso.Count && DNI != curso[i].devolverDNI()) 
              {
                i++;
              }
              this.curso[i].agregarFalta(falta);
            }
            else
            {
              System.Console.WriteLine("No se encontro el alumno");
            }
            
        }
        public void mostrarAlumnos () 
        {
          foreach (Alumno a in curso) 
          {
            a.mostrarDatos();
          }
        }
        public void mostrarAlumnosLibres ()
        {
          foreach (Alumno a in curso)
          {
            if (a.devolverFaltas() >= 15)
            {
              a.mostrarDatos();
            }
          }
        }
    }
}