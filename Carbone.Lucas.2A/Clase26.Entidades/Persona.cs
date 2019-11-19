using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clase26.EntidadesTest
{
    public class Persona
    {
        protected string nombre;
        protected string apellido;
        protected int dni;
        
        public Persona(string nombre,string apellido,int dni)
        {
            this.nombre = nombre;
            this.apellido = apellido;
            this.dni = dni;
        }
        #region Propiedades
        public string Nombre
        {
            get { return this.nombre; }
        }
        public string Apellido
        {
            get { return this.apellido; }
        }
        public int DNI
        {
            get { return this.dni; }
        }
        #endregion

        #region Getters
        public string GetNombre()
        {
            return this.nombre;
        }
        public string GetApellido()
        {
            return this.apellido;
        }
        public int GetDNI()
        {
            return this.dni;
        }
        #endregion
        public string ObtenerInfo()
        {
            return this.Apellido + " - " + this.Nombre + " - " + this.DNI;
        }


    }
}
