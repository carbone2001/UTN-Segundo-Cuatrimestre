using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ejercicio16
{
    class Alumno
    {
        private byte nota1;
        private byte nota2;
        private float notaFinal;
        public string apellido;
        public int legajo;
        public string nombre;

        public void CalcularFinal()
        {
            if(this.nota1 >= 4 && this.nota2 >= 4)
            {
                Random aleatorio = new Random();
                notaFinal = (float)(aleatorio.Next(1,10));
            }
            else
            {
                this.notaFinal = -1;
            }
        }
        public void Estudiar(byte notaUno, byte notaDos)
        {
            this.nota1 = notaUno;
            this.nota2 = notaDos;
        }
        public string Mostrar()
        {
            string msj;

            if(this.notaFinal != -1)
            {
                
                msj = this.notaFinal.ToString();
            }
            else
            {
                msj = "Alumno desaprobado";
            }
            return msj;
        }
    }
}
