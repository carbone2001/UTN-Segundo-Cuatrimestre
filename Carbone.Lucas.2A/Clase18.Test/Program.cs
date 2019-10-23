using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Clase18.Entidades;
namespace Clase18.Test
{
    class Program
    {
        
        static void Main(string[] args)
        {
            ///Aviones
            
            Avion avion1 = new Avion(200000, 1200);
            Privado privado1 = new Privado(150000,900,8);
            Comercial comercial1 = new Comercial(600000,850,20);
            Console.WriteLine("Aviones:");
            Console.WriteLine("Impuesto avion: "+(Gestion.MostrarImpuestoNacional(avion1)));
            Console.WriteLine("Impuesto avion Privado : " + (Gestion.MostrarImpuestoNacional(privado1)));
            Console.WriteLine("Impuesto avion Comercial: " + (Gestion.MostrarImpuestoNacional(comercial1)));

            ///Autos
            ///
            Console.WriteLine("Autos:");
            Deportivo deportivo1 = new Deportivo(10000, "utn350",500);
            Console.WriteLine("Impuesto auto deportivo : " + (Gestion.MostrarImpuestoNacional(deportivo1)));
            /// Carreta
            
            Console.WriteLine("Carreta:");
            Carreta carreta1 = new Carreta(10000);
            Console.WriteLine("Impuesto Carreta : " + (Gestion.MostrarImpuestoProvincial(carreta1)));


            Console.Read();
        }

        
    }
}
