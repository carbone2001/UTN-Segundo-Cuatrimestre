using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ejercicio48
{
    class Program
    {
        static void Main(string[] args)
        {
            Factura f1 = new Factura(1);
            Factura f2 = new Factura(2);
            Factura f3 = new Factura(3);
            Recibo r1 = new Recibo(1);
            Recibo r2 = new Recibo(2);
            Recibo r3 = new Recibo(3);
            Contabilidad<Factura, Recibo> c = new Contabilidad<Factura, Recibo>();
            Console.WriteLine("Agrego factura!");
            c += f1;
            Console.WriteLine("Agrego Recibo!");
            c += r1;
            Console.ReadLine();
        }
    }
}
