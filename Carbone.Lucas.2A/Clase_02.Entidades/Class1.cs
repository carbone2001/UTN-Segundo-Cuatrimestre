using System;

namespace Clase_02.Entidades
{
    public class Sello
    {
        public static string mensaje;
        private static string msj;
        public static ConsoleColor color;
        public static string Imprimir()
        {
            msj = "";
            msj = ArmarFormatoMensaje();
            Console.ForegroundColor = ConsoleColor.Gray;
            Console.WriteLine(msj);
            return Sello.mensaje;
        }
        public static void Borrar()
        {
            Sello.mensaje = "";
        }
        public static void ImprimirEnColor()
        {
            msj = "";
            msj = ArmarFormatoMensaje();
            Console.ForegroundColor = Sello.color;
            Console.WriteLine(msj);
            Console.ForegroundColor = ConsoleColor.Gray;
            Console.ReadLine();
        }
        private static string ArmarFormatoMensaje()
        {
            string msj = "";
            string techo = "";
            int len = Sello.mensaje.Length;
            if (len != 0)
            {
                msj = "\n******\n*" + Sello.mensaje + "*\n*******";
                for (int i = 0; i < len; i++)
                {
                    techo += "*";
                }
                techo += "**";
                msj = techo + "\n*" + Sello.mensaje + "*\n" + techo;
            }


            return msj;
        }
    }
}
