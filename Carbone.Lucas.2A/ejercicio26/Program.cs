using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ejercicio26
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] vectorNumeros = new int[20];
            Random random = new Random();
            for(int i=0;i<20;i++)
            {
                do
                {
                    vectorNumeros[i] = random.Next(100);
                } while (vectorNumeros[i] == 0);
            }
            //Mostrar vector
            for (int i = 0; i < 20; i++)
                Console.Write("{0} ", vectorNumeros[i]);
            Console.WriteLine("\n");

            //Ordenar decrecientemente
            int aux;
            Console.WriteLine("Ordenado decreciente");
            for (int i=0; i<20-1;i++)
            {
                for(int j=i+1;j<20;j++)
                {
                    if(vectorNumeros[i]<vectorNumeros[j])
                    {
                        aux = vectorNumeros[i];
                        vectorNumeros[i] = vectorNumeros[j];
                        vectorNumeros[j] = aux;
                    }
                }
            }
            for (int i = 0; i < 20; i++)
                Console.Write("{0} ", vectorNumeros[i]);
            Console.WriteLine("\n");

            //Ordenar crecientemente
            Console.WriteLine("Ordenado creciente");
            for (int i = 0; i < 20 - 1; i++)
            {
                for (int j = i+1; j < 20; j++)
                {
                    if (vectorNumeros[i] > vectorNumeros[j])
                    {
                        aux = vectorNumeros[i];
                        vectorNumeros[i] = vectorNumeros[j];
                        vectorNumeros[j] = aux;
                    }
                }
            }
            for (int i = 0; i < 20; i++)
                Console.Write("{0} ", vectorNumeros[i]);
            Console.WriteLine("\n");

            Console.Read();

        }
    }
}
