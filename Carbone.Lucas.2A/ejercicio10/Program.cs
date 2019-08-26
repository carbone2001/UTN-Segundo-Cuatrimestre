using System;

namespace ejercicio10
{
    class Program
    {


        static void Main(string[] args)
        {
            int escalones;
            int escalonesHechos = 0;
            int cantidadEspacios = 0;
            int cantidadEspaciosAntes = 0;
            //int cantidadEspaciosDespues = 0;
            string espacios = "";
            string asteriscos = "";

            Console.Title = "Ejercicio 10";
            Console.Write("Ingrese tamanio de piramide: ");
            escalones = int.Parse(Console.ReadLine());

            if (escalones > 0)
            {
                //Calculador de espacio
                for (int i = 0; i < escalones; i++)
                {
                    if (i == 0)
                    {
                        cantidadEspacios++;
                        continue;
                    }
                    cantidadEspacios += 2;
                }


                for (int i = 1; escalonesHechos < escalones; i++)
                {
                    espacios = "";
                    if (i == 1)
                    {
                        //Dividimos a la mitad la cantidad maxima de espacios y restamos un espacio para incertar el asterisco en el centro
                        cantidadEspaciosAntes = cantidadEspacios / 2 - (escalonesHechos - 1);
                        asteriscos += "*";
                        //Llenamos la variable espacios de... si... espacios...
                        for (int j = 0; j < cantidadEspaciosAntes; j++)
                        {
                            espacios += " ";
                        }
                        //colocamos el asterisco entre los dos espacios
                        Console.WriteLine(espacios + asteriscos + espacios);
                        escalonesHechos++;
                        continue;
                    }

                    //Lo mismo pero ahora sumamos...
                    cantidadEspaciosAntes = cantidadEspacios / 2 - (escalonesHechos - 1);
                    asteriscos += "**";//... de a dos asteriscos.
                    for (int j = 0; j < cantidadEspaciosAntes; j++)
                    {
                        espacios += " ";
                    }
                    Console.WriteLine(espacios + asteriscos + espacios);
                    escalonesHechos++;
                }
            }
            Console.ReadLine();
        }
    }
}