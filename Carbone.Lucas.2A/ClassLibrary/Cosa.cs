using System;

namespace ClassLibrary
{
    public class Cosa
    {
        private int entero;
        private string cadena;
        private DateTime fecha;
        public string Mostrar()
        {
            return this.entero + " - " + this.cadena + " - " + this.fecha + "\n";
        }
        public void EstablecerValor(int input)
        {
            this.entero = input;
        }
        public void EstablecerValor(string input)
        {
            this.cadena = input;
        }
        public void EstablecerValor(DateTime input)
        {
            this.fecha = input;
        }
        public Cosa()
        {
            this.entero = -1;
            this.cadena = "Sin valor";
            this.fecha = DateTime.Now;
        }
        public Cosa(string input) : this()//Esto invoca a Cosa(). y luego inicializo solo this.cadena
        {
            //this.entero = -1;
            this.cadena = input;
            //this.fecha = DateTime.Now;
        }
        public Cosa(string cad, DateTime dat) : this(cad)//Esto invoca Cosa(string input). El parametro de this() debe ser la variable que ingresa en el constructor que invoca, NO el invocado.
        {
            //this.entero = -1;
            //this.cadena = cad;
            this.fecha = dat;
        }
        public Cosa(string cad, DateTime dat, int ent) : this(cad, dat)
        {
            this.entero = ent;
            //this.cadena = cad;
            //this.fecha = dat;
        }


    }
}
