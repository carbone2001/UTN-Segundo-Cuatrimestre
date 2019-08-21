using System;

namespace ejercicio_01
{
    class Program
    {
        static void Main(string[] args)
        {

            /*Console.Title = "Ejercicio de bienvenida";
            Console.WriteLine("Hola mundo C#");
            String nombre = Console.ReadLine();
            String apellido = Console.ReadLine();
            /*String nombre = "Lucas";
            String apellido = "Carbone";
            String localidad;
            Console.WriteLine("Mi nombre es {1} {0}", apellido, nombre);
            localidad = Console.ReadLine();
            Console.WriteLine("Localidad: {0}", localidad);
            Console.ReadLine();*/
            int minimo = 0;
            int maximo = 0;
            int input;
            int suma = 0;
            float promedio;
            int i;
            Console.Write("Ingrese 5 numeros: \n");
            for (i = 0; i < 5; i++)
            {
                Console.Write("Numero {0}: ", i + 1);
                input = int.Parse(Console.ReadLine());
                if (i == 0)
                {
                    minimo = input;
                    maximo = input;
                }
                else if (input > maximo)
                {
                    maximo = input;
                }
                else if (input < minimo)
                {
                    minimo = input;
                }
                suma = suma + input;
            }
            promedio = (float)suma / i;
            Console.Write("\n\nPromedio: {0} \nMaximo: {1} \nMinimo: {2}", promedio, maximo, minimo);
            Console.ReadLine();
        }
    }
}
