using System;
using System.Collections.Generic;
using System.Text;

namespace Clase15.EntidadesPracticaParcial
{
    public class Alumno
    {
        private string _apellido;
        private int _legajo;
        private string _nombre;
        private float _nota;

        #region Propiedades
        public string Apellido
        {
            get { return this._apellido; }
            set { this._apellido = value; }
        }
        public int Legajo
        {
            get { return this._legajo; }
            set { this._legajo = value; }
        }
        public string Nombre
        {
            get { return this._nombre; }
            set { this._nombre = value; }
        }
        public float Nota
        {
            get { return this._nota; }
            set { this._nota = value; }
        }

        #endregion

        #region Metodos
        public Alumno (int legajo, string nombre, string apellido):this(nombre,apellido)
        {
            this.Legajo = legajo;
        }
        public Alumno(int legajo):this(0f)
        {
            this.Legajo = legajo;
        }
        public Alumno(string nombre,string apellido):this(0)
        {
            this.Nombre = nombre;
            this.Apellido = apellido;
        }
        public Alumno(float Nota):this()
        {
            this.Nota = Nota;
        }
        public Alumno()
        {
            this.Legajo = 0;
            this.Nombre = "";
            this.Apellido = "";
            this.Nota = 0f;
        }
        private string Mostrar()
        {
            return "Legajo: "+this.Legajo+" Nombre: "+this.Nombre+" Apellido: "+this.Apellido+" Nota: "+this.Nota;
        }
        public static string Mostrar(Alumno alumno)
        {
            return alumno.Mostrar();
        }
        public static bool operator ==(Alumno a1, Alumno a2)
        {
            if(a1.Legajo == a2.Legajo)
                return true;
            return false;
        }
        public static bool operator !=(Alumno a1, Alumno a2)
        {
            return !(a1 == a2);
        }

        #endregion
    }
}
