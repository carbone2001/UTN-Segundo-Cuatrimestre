using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Clase26.EntidadesTest;
using Entidades.Externa;
using eh=Entidades.Externa.Sellada;
namespace Clase26.Consola
{
    class Program
    {
        static void Main(string[] args)
        {
            Persona p = new Persona("ElNombre", "ElApellido", 12341234);
            Console.WriteLine("Con Propiedades");
            Console.WriteLine("{0} - {1} - {2}", p.Apellido, p.Nombre, p.DNI);
            Console.WriteLine("\nCon Getters");
            Console.WriteLine("{0} - {1} - {2}", p.GetApellido(), p.GetNombre(), p.GetDNI());
            Console.WriteLine("\nCon Metodo");
            Console.WriteLine(p.ObtenerInfo());
            Console.WriteLine("\nPersonaHerencia");
            PersonaHerencia ph = new PersonaHerencia("ElNombreHerencia","ElApellidoHerencia",300,ESexo.Indefinido );
            Console.WriteLine(ph.ObtenerInfo());
            Console.WriteLine("\nPersonaHerenciaSellada");
            eh.PersonaExternaSellada ps = new eh.PersonaExternaSellada("ElNombreSellada", "ElApellidoSellada", 2600,eh.ESexo.Indefinido);
            Console.WriteLine(ps.ObtenerInfo());
            Console.WriteLine("\nProbando EsNulo()");
            Object obj = null;
            Console.WriteLine(obj.EsNulo());
            List<Persona> listaPersona = p.ObtenerListadoBD();
            try
            {
                foreach (Persona x in listaPersona)
                    Console.WriteLine(x.ObtenerInfo());
            }
            catch (Exception)
            {
                Console.WriteLine("Error base de datos");
            }
            Console.Read();
        }
    }
}
