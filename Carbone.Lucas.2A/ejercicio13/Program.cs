using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LibreriaEjercicios;

namespace ejercicio13
{
    class Program
    {
        static void Main(string[] args)
        {
            double number;
            string numberToDecimal;
            Console.Write("Ingrese numero decimal: ");
            number = Double.Parse(Console.ReadLine());
            Console.WriteLine("Numero a binario: {0}", Conversor.DecimalBinario(number));
            numberToDecimal = Conversor.DecimalBinario(number);
            Console.Write("Numero a decimal: {0}", Conversor.BinarioDecimal(numberToDecimal));
            Console.ReadLine();
        }
    }
}
