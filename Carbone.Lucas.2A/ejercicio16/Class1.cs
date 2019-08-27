using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ejercicio16
{
    class Alumno
    {
        private static byte nota1;
        private static byte nota2;
        private static float notaFinal;
        public static string apellido;
        public static int legajo;
        public static string nombre;

        public static void CalcularFinal()
        {
            if(nota1 >= 4 && nota2 >= 4)
            {
                Random aleatorio = new Random();
                notaFinal = (float)(aleatorio.Next(1,10));
            }
            else
            {
                Alumno.notaFinal = -1;
            }
        }
        public static void Estudiar(byte notaUno, byte notaDos)
        {
            Alumno.nota1 = notaUno;
            Alumno.nota2 = notaDos;
        }
        /*public static string Mostrar()
        {
            return this.;
        }*/
    }
}
