using System;

namespace ejercicio_04
{
    class Program
    {
        static void Main(string[] args)
        {
            int suma;
            int numero = 6;
            int cant = 0;
            Console.Title = "Ejercicio 4";
            Console.WriteLine("Numeros perfectos");
            while (cant != 4)
            {
                suma = 0;
                for (int j = 1; j < numero; j++)//Busco un numero j...
                {
                    if (numero % j == 0)//...que sea divisor de la variable numero
                    {
                        suma = suma + j; //Si lo hay se suma
                    }
                }
                if (suma == numero)//Si la suma de los divisores es igual al numero...
                {
                    Console.WriteLine("{0}", numero);//Lo imprimo
                    cant++;
                }
                numero++;//Incremento el valor de la variable en busca de otro numero perfecto
            }
            Console.ReadLine();
        }
    }
}
