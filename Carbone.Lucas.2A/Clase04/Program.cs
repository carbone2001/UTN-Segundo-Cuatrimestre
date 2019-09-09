using ClassLibrary;
using System;

/*namespace ClassLibrary
{
    public class Cosa
    {
        public int entero;
        public string cadena;
        public DateTime fecha;
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


    }
}*/

namespace Clase04
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "Clase 04";
            DateTime data = new DateTime();
            data = data.AddDays(10);
            data = data.AddYears(10);
            data = data.AddMonths(10);


            int entero = 400;
            string cadena = "Cad 1";

            Cosa obj1 = new Cosa();
            Cosa obj2 = new Cosa(cadena);
            Cosa obj3 = new Cosa(cadena, data);
            Cosa obj4 = new Cosa(cadena, data, entero);
            Console.WriteLine("Sin parametros: " + obj1.Mostrar());
            Console.WriteLine("Cadena: " + obj2.Mostrar());
            Console.WriteLine("Cadena, fecha: " + obj3.Mostrar());
            Console.WriteLine("Cadena, fecha y entero: " + obj4.Mostrar());

            Console.Read();

        }
    }
}
