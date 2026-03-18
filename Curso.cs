using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Act1._5
{
    public class Curso
    {
        private List <Alumno> curso;
        public Curso ()
        {
            this.curso = new List <Alumno> ();
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
          int i=0;
          Alumno alumno = null;
          while (i<this.curso.Count && a.devolverDNI() != curso[i].devolverDNI())
          {
            i++
          }
          if (i < this.curso.Count)
          {
            alumno = curso[i];
          }
          return alumno;
        }
        public bool agregarFalta (int DNI, double falta)
        {
            Alumno a = null;
            a = buscarAlumno(DNI);
            if (a != null)
            {
              a.agregarFalta(falta);
            }
            else
            {
              System.Console.WriteLine("No se encontro el alumno");
            }
            
        }
    }
}