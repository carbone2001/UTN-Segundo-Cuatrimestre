using System;

namespace ejercicio_05
{
    class Program
    {
        static void Main(string[] args)
        {
            int num;
            int sumaAntes = 0; //Suma de numeros anteriores al ingresado
            int sumaDespues = 0; //Suma de numeros posteriores al ingresado
            Console.Title = "Ejercicio 5";
            Console.WriteLine("Ingrese numero: ");
            num = int.Parse(Console.ReadLine());
            for (int i = 1; i < num; i++)
            {
                sumaAntes = sumaAntes + i;
            }
            for (int i = num + 1; sumaDespues < sumaAntes; i++)//A partir del numero siguiente al ingresado iterar hasta dar igual o mayor a sumaAntes
            {
                sumaDespues = sumaDespues + i;
            }
            if (sumaAntes == sumaDespues)//Si la suma de numeros anteriores es igual a la suma de los numeros posteriores
            {
                Console.WriteLine("El numero {0} es un centro numerico. Las sumas de ambas partes son {1} y {2}", num, sumaAntes, sumaDespues);
            }
            else
            {
                Console.WriteLine("El numero {0} no puede ser un centro numerico", num);
            }
            Console.WriteLine();
        }
    }
}
