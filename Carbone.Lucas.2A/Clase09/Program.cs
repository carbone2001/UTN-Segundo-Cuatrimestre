using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Clase09.Entidades;

namespace Clase09
{
    class Program
    {
        static void Main(string[] args)
        {
            Libro miLibro = new Libro("C# al descubierto", "Joe Mayo");

            miLibro[0] = "Fundamentos Básicos de C#";
            miLibro[1] = "Cómo comenzar con C#";
            miLibro[2] = "Cómo escribir expresiones con C#";

            miLibro[-1] = "Genero un índice erroneo";

            miLibro[5] = "Genero otro índice erroneo";





            Console.WriteLine("Libro:");

            Console.WriteLine("Titulo: {0}", miLibro.Titulo);

            Console.WriteLine("Autor: {0}", miLibro.Autor);

            Console.WriteLine("Cantidad de páginas: {0}", miLibro.CantidadPaginas);



            for (int i = 0; i < miLibro.CantidadDeCapitulos; i++)

            {

                Console.WriteLine("Capitulo {0}: {1} {2}", miLibro[i].Numero, miLibro[i].Titulo, miLibro[i].Paginas);

            }


            Console.ReadLine();
            /*Capitulo c1 = "Primer capitulo";
            Capitulo c2 = "Segundo capitulo";
            Capitulo c3 = "Tercer capitulo";

            Console.WriteLine("Numero: {0} - Titulo: {1} - Paginas: {2}", c1.Numero, c1.Titulo, c1.Paginas);
            Console.WriteLine("Numero: {0} - Titulo: {1} - Paginas: {2}", c2.Numero, c2.Titulo, c2.Paginas);
            Console.WriteLine("Numero: {0} - Titulo: {1} - Paginas: {2}", c3.Numero, c3.Titulo, c3.Paginas);

            
            Libro l1 = new Libro("ElTitulo", "ElNombreAutor");
            l1[0] = c1;
            Console.WriteLine(l1[0]);
            Console.WriteLine(l1.cantidadPaginas);

            Console.Read();*/


        }
    }
}
