using System;
using System.Collections.Generic;

namespace ejercicio27
{
    class Program
    {
        static void Main(string[] args)
        {
            Stack<int> numerosStack = new Stack<int>();
            Queue<int> numerosQueue = new Queue<int>();
            List<int> numerosList = new List<int>();
            Random randomNumber = new Random();
            int number;
            int countStack;
            int countQueue;
            for (int i = 0; i < 20; i++)
            {
                number = randomNumber.Next(int.MaxValue);
                numerosStack.Push(number);
                numerosQueue.Enqueue(number);
                numerosList.Add(number);
            }
            countStack = numerosStack.Count;
            Console.WriteLine("Numeros cargados en Pila: ");
            for (int i = 0; i < countStack; i++)
            {
                Console.WriteLine(" {0} ", numerosStack.Pop());
            }

            countQueue = numerosQueue.Count;
            Console.WriteLine("\nNumeros cargados en Cola: ");
            for (int i = 0; i < countStack; i++)
            {
                Console.WriteLine(" {0} ", numerosQueue.Dequeue());
            }

            Console.WriteLine("\nNumeros cargados en Lista: ");
            for (int i = 0; i < 20; i++)
            {
                Console.WriteLine(" {0} ", numerosList[i]);
            }
            numerosList.Sort();

            Console.WriteLine("\nNumeros cargados en Lista (Ordenada Creciente): ");
            for (int i = 0; i < 20; i++)
            {
                Console.WriteLine(" {0} ", numerosList[i]);
            }
            numerosList.Reverse();
            Console.WriteLine("\nNumeros cargados en Lista (Ordenada Decreciente): ");
            for (int i = 0; i < 20; i++)
            {
                Console.WriteLine(" {0} ", numerosList[i]);
            }
            Console.Read();




        }
    }
}
