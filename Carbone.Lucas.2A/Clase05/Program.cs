using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Clase05.Entidades;

namespace Clase05
{
    class Program
    {
        static void Main(string[] args)
        {
            Pluma p1 = new Pluma();
            Pluma p2 = new Pluma();
            Tinta t1 = new Tinta();
            Tinta t2 = new Tinta();
            t1 = null;
            p1 = null;
            if(t1 == t2)
            Console.WriteLine("Ambos son null");
            Console.Read();
        }
    }
}
