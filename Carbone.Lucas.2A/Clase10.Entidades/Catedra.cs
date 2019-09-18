using System;
using System.Collections.Generic;

namespace Clase10.Entidades
{
    public class Catedra
    {
        private List<Alumno> alumnos;
        public List<Alumno> Alumnos
        {
            get
            {
                return alumnos;
            }
        }
        public Catedra()
        {
            this.alumnos = new List<Alumno>();
        }
        public static bool operator ==(Catedra c, Alumno a)
        {
            if (c.alumnos.Contains(a))
                return true;
            return false;
        }
        public static bool operator !=(Catedra c, Alumno a)
        {
            return !(c==a);
        }
        public static int operator |(Alumno a,Catedra c)
        {
            return c.Alumnos.IndexOf(a);
        }
        public static bool operator -(Catedra c, Alumno a)
        {
            if(c==a)
            {
                c.Alumnos.RemoveAt(a | c);
                return true;
            }
            else
            {
                return false;
            }
            
        }
        public static bool operator +(Catedra c, Alumno a)
        {
            if(c.alumnos.Contains(a))
            {
                
                return false;
            }
            else
            {
                c.Alumnos.Add(a);
                return true;
            }
        }
    }
}
