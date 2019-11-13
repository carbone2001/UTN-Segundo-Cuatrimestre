using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clase25.Entidades
{
    public class Empleado
    {
        private string nombre;
        private string apellido;
        private int legajo;
        private double sueldo;
        public event LimiteSueldoMejoradoDel limiteSueldoMejorado;
        public event LimiteSueldoDelegado limiteSueldo;

        public Empleado(string nombre, string apellido, int legajo)
        {
            this.nombre = nombre;
            this.apellido = apellido;
            this.legajo = legajo;
        }

        public string Nombre
        {
            get
            {
                return this.nombre;
            }
            set
            {
                this.nombre = value;
            }
        }
        public string Apellido
        {
            get { return this.apellido; }
            set { this.apellido = value; }
        }
        public int Legajo { get { return this.legajo; } set { this.legajo = value; } }
        public double Sueldo { get { return this.sueldo; }
            set
            {
                if (value > 18000f && value <= 30000)
                    this.limiteSueldo(value, this);
                else if (value > 30000f)
                {
                    EmpleadoEventArgs e = new EmpleadoEventArgs();
                    e.SueldoAsignar = value;
                    this.limiteSueldoMejorado(this, e);
                }
                else
                    this.sueldo = value;
            }
        }

        public override string ToString()
        {
            return String.Format("Legajo: {0} Nombre: {1} Apellido: {2} Sueldo: {3}",this.legajo,this.nombre,this.apellido,this.sueldo);
        }

    }
}
