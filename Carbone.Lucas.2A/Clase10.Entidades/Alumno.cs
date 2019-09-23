using System;
namespace Clase10.Entidades
{
    public class Alumno
    {
        protected string apellido;
        protected ETipoExamen examen;
        protected int legajo;
        protected string nombre;

        public string Apellido
        {
            get { return this.apellido; }
        }
        public ETipoExamen Examen
        {
            get { return this.examen; }
        }
        public int Legajo
        {
            get { return this.legajo; }
        }
        public string Nombre
        {
            get { return this.nombre; }
        }
        public Alumno(string nombre, string apellido, int legajo, ETipoExamen examen)
        {
            this.nombre = nombre;
            this.apellido = apellido;
            this.legajo = legajo;
            this.examen = examen;
        }
        public static string Mostrar(Alumno a)
        {
            return "Legajo: " + a.Legajo + " Apellido: " + a.Apellido + " Nombre: " + a.Nombre + " Examen: " + a.Examen.ToString() + "\n";
        }

        public static bool operator ==(Alumno a, Alumno b)
        {
            if(!Object.Equals(a,null) && !Object.Equals(b,null))
            {
                if (a.Legajo == b.Legajo)
                    return true;
            }
            else
            {
                return Object.Equals(a, b);
            }
            
            return false;
        }
        public static bool operator !=(Alumno a, Alumno b)
        {
            return !(a == b);
        }

        public static int OrdenarPorApellidoDesc(Alumno a, Alumno b)
        {
            return String.Compare(a.Apellido, b.Apellido);
        }
        public static int OrdenarPorApellidoAsc(Alumno a, Alumno b)
        {
            return OrdenarPorApellidoDesc(b, a);
        }
        public static int OrdenarPorLegajoDesc(Alumno a, Alumno b)
        {
            if (a.Legajo > b.Legajo)
                return 1;
            else if (a.Legajo == b.Legajo)
                return 0;
            else
                return -1;
        }
        public static int OrdenarPorLegajoAsc(Alumno a, Alumno b)
        {
            return OrdenarPorLegajoDesc(b, a);
        }
    }
}
