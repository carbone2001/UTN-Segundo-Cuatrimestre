using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clase_02.Entidades
{
    public class Sello
    {
        public static string mensaje;
        //private static string msj;
        public static ConsoleColor color;
        public static string Imprimir()
        {
            
            Console.ForegroundColor = ConsoleColor.Gray;
            Console.WriteLine(Sello.mensaje);
            return Sello.mensaje;
        }
        public static void Borrar()
        {
            Sello.mensaje = null;
        }
        public static void ImprimirEnColor()
        {
            Sello.mensaje = ArmarFormatoMensaje();
            Console.ForegroundColor = Sello.color;
            Console.WriteLine(Sello.mensaje);
            Console.ForegroundColor = ConsoleColor.Gray;
            Console.ReadLine();
        }
        private static string ArmarFormatoMensaje()
        {
            string msj;
            string techo = "";
            int len = Sello.mensaje.Length;
            msj = "\n******\n*" + Sello.mensaje + "*\n*******";
            for(int i=0;i<len;i++)
            {
                techo += "*";
            }
            techo += "**";
            msj = techo + "\n*" + Sello.mensaje + "*\n" + techo; 

            return msj;
        }
    }
}
