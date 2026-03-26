using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Act1._5
{
    public class Curso
    {
        private Dictionary <int,Alumno> dicAlumnos;
        public Curso ()
        {
             this.dicAlumnos = new Dictionary<int, Alumno>();
        }
        public bool agregarAlumno(string nombre, int DNI)
        {
          if (dicAlumnos.ContainsKey(DNI)) return false;
          Alumno a = new Alumno(DNI, nombre);
          dicAlumnos.Add(DNI, a);
          return true;
        }
        public Alumno buscarAlumno (int DNI)
        {
          if (dicAlumnos.ContainsKey(DNI)) return dicAlumnos[DNI];
          else return null;
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
        public Dictionary <int, Alumno> listarLibres ()
        {
          Dictionary<int, Alumno> alumnosLibres =new Dictionary<int,Alumno>();
          foreach(int clave in dicAlumnos.Keys)
          {
            if (dicAlumnos[clave].mostrarFaltas()>15) alumnosLibres.Add()
          }
          return dicAlumnos;
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