using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Clase25.Entidades;
namespace Clase25.Test
{
    class Program
    {
        static void Main(string[] args)
        {
            Program prog = new Program();
            Empleado e1 = new Empleado("Juan", "Perez", 123);
            e1.limiteSueldo += new LimiteSueldoDelegado(prog.Manejador_LimiteSueldo);
            e1.limiteSueldoMejorado += new LimiteSueldoMejoradoDel(Program.Manejador_LimiteSueldoMejorado);
            e1.limiteSueldoMejorado += new LimiteSueldoMejoradoDel(prog.Manejador_LimiteSueldoMejorado2);
            e1.Sueldo = 33000f;
            //e1.limiteSueldo;
            //Console.WriteLine(e1.ToString());
            Console.Read();
        }
        public void Manejador_LimiteSueldo(double value,Empleado emp)
        {
            Console.WriteLine(emp.ToString() + " LIMITE SUELDO (" + value + ")");
        }
        public static void Manejador_LimiteSueldoMejorado(Empleado emp,EmpleadoEventArgs e)
        {
            Console.WriteLine(emp.ToString() + " LIMITE SUELDO MEJORADO: " + e.SueldoAsignar);
        }
        public void Manejador_LimiteSueldoMejorado2(Empleado emp, EmpleadoEventArgs e)
        {
            Console.WriteLine(emp.ToString() + " LIMITE SUELDO MEJORADO2: " + e.SueldoAsignar );
        }
    }
}
