using System;
using System.Collections.Generic;
using System.Text;

namespace ClassLibrary
{
    public class Cosa
    {
        public int entero;
        public string cadena;
        public DateTime fecha;
        public string Mostrar()
        {
            return this.entero+" - "+this.cadena +" - "+this.fecha+"\n";
        }
        public  void EstablecerValor(int input)
        {
            this.entero = input;
        }
        public  void EstablecerValor(string input)
        {
            this.cadena = input;
        }
        public void EstablecerValor(DateTime input)
        {
            this.fecha = input;
        }


    }
}
