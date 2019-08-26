using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LibreriaEjercicios;

namespace ejercicio12
{
    class Program
    {
        static void Main(string[] args)
        {
            double numero;
            double suma = 0;

            do
            {
                Console.Write("Ingrese numero: ");
                numero = double.Parse(Console.ReadLine());
                suma += numero;
                Console.Write("¿Continuar ? (S / N)");
                
            } while (ValidarRespuesta.ValidaS_N(char.Parse(Console.ReadLine())));
            Console.Write("El resultado de la suma es {0}",suma);
            Console.ReadLine();
        }
    }
}
