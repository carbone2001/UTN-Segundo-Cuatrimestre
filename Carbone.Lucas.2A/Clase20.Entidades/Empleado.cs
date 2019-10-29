using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clase20.Entidades
{
    public class Empleado:Persona
    {
        public int legajo;
        public double sueldo;

        public Empleado():base()
        {

        }
        public Empleado(int legajo, double sueldo):this()
        {
            this.legajo = legajo;
            this.sueldo = sueldo;
        }

        public override string ToString()
        {
            return base.ToString()+" legajo: "+this.legajo+" Sueldo: "+this.sueldo;
        }
    }
}
