using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clase20.Entidades
{
    class Alumno : Persona
    {
        public double nota;

        public Alumno():base()
        {

        }
        public Alumno(double nota):this()
        {
            this.nota = nota;
        }

        public override string ToString()
        {
            return base.ToString()+" Nota: "+this.nota;
        }
    }
}
