using System;
using System.Collections.Generic;
using System.Text;
namespace Clase15.EntidadesPracticaParcial
{
    public class Materia
    {
        private List<Alumno> _alumnos;
        private EMateria _nombre;
        private static Random _notaParaUnAlumno;

        #region Propiedades
        public List<Alumno> Alumnos
        {
            get { return this._alumnos; }
            set { this._alumnos = value; }
        }

        public EMateria Nombre
        {
            get { return this._nombre; }
            set { this._nombre = value; }
        }
        #endregion
        #region Metodos
        public void CalificarAlumnos()
        {
            foreach(Alumno a in this.Alumnos )
            {
                a.Nota = _notaParaUnAlumno.Next(1, 10);
            }
        }
        public static explicit operator string(Materia materia)
        {
            return materia.Mostrar();
        }
        public static implicit operator float(Materia m)
        {
            int cantidadAlumnos = m.Alumnos.Count;
            float notasTotales=0;
            foreach(Alumno a in m.Alumnos)
            {
                notasTotales += a.Nota;
            }
            return notasTotales/cantidadAlumnos;
        }
        public static implicit operator Materia(EMateria nombre)
        {
            Materia e = new Materia();
            e.Nombre = nombre;

            return e;
        }
        private Materia()
        {
            this.Alumnos = new List<Alumno>();
        }
        static Materia() { _notaParaUnAlumno = new Random();  }
        private Materia(EMateria nombre) { this.Nombre = nombre; }
        private string Mostrar()
        {
            StringBuilder mostrar = new StringBuilder();
            mostrar.AppendFormat("Materia: {0} \n", this.Nombre.ToString());
            mostrar.AppendLine("************************************");
            mostrar.AppendLine("****************ALUMNOS*************");
            foreach(Alumno a in this.Alumnos)
            {
                mostrar.AppendFormat("{0}\n",Alumno.Mostrar(a));
            }
            return mostrar.ToString();
        }
        public static bool operator !=(Materia m, Alumno a)
        {
            return !(m == a);
        }
        public static Materia operator -(Materia m, Alumno a)
        {
            if(m==a)
            {
                m.Alumnos.Remove(a);
            }
            return m;
        }
        public static Materia operator +(Materia m, Alumno a)
        {
            if(m != a)
            {
                m.Alumnos.Add(a);
            }
            return m;
        }
        public static bool operator ==(Materia m, Alumno a)
        {
            foreach(Alumno alumno in m.Alumnos)
            {
                if(a == alumno)
                {
                    return true;
                }
            }
            return false;
        }
        
        #endregion
    }
}
