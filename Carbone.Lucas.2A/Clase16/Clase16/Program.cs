using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Clase16_
{
    class Program
    {
        public static void Metodo1()
        { try
            { Program.Metodo2(); }
            catch (Exception e)
            {
                Console.WriteLine("Estoy en el metodo 1");
                Console.WriteLine(e.InnerException.InnerException.Message);
                throw new Exception("Excepcion metodo 1",e);

            }
        }
        public static void Metodo2()
        {
            try { Program.Metodo3(); }
            catch (DirectoryNotFoundException e)
            {
                Console.WriteLine("Estoy en el metodo 2");
                Console.WriteLine(e.InnerException.Message);
                throw new Exception("Excepcion metodo 2", e);
            }
        }
        public static void Metodo3() {
            try { Program.Metodo4(); }
            catch (ArgumentException e)
            {
                Console.WriteLine("Estoy en el catch del Metodo 3");
                //Console.WriteLine(e.Message);
                Console.WriteLine(e.Message);
                throw new DirectoryNotFoundException("Excepcion metodo 3", e);

            }
        }
        public static void Metodo4() { Console.WriteLine("Estoy en el metodo 4"); throw new ArgumentException("Excepcion del Metodo 4"); }





        static void Main(string[] args)
        {

            //Escribir archivo
            /*
            try
            {
                using (StreamWriter a = new StreamWriter(@"C:\miCarpeta\miArchivo.txt", true))
                {
                    a.WriteLine("Hola Mundo");
                    a.WriteLine(DateTime.Now);
                }
            }
            catch(ArgumentException e)
            {
                Console.WriteLine(e.ToString());
            }
            catch (DirectoryNotFoundException e)
            {
                Console.WriteLine(e.ToString());
            }
            catch (Exception e)
            {
                Console.WriteLine(e.ToString());

            }
            //Leer el archivo
            finally
            {
                using (StreamReader b = new StreamReader(@"C:\miCarpeta\miArchivo.txt"))
                {
                    string linea;
                    while((linea = b.ReadLine()) != null)
                    { 
                        Console.WriteLine(linea);
                    }
                }
                Console.ReadLine();
            }*/
            try
            {
                Program.Metodo1();
            }
            catch(Exception e)
            {
                Console.WriteLine(e.StackTrace);
                //Console.WriteLine(e.Message);
                try
                {
                    using (StreamWriter sw = new StreamWriter(AppDomain.CurrentDomain.BaseDirectory+"\\incidencias.log"))
                    {
                        sw.WriteLine(e.StackTrace);
                    }
                    using (StreamWriter sw = new StreamWriter(Environment.GetFolderPath(Environment.SpecialFolder.Desktop) + "\\incidencias.log"))
                    {
                        sw.WriteLine(e.StackTrace);
                    }
                }
                catch
                {

                }
            }
            Console.ReadLine();
        }
    }

    public class Metodo4Exception : Exception
    {
        public Metodo4Exception(string mensaje):base(mensaje)
        {
        }
        public Metodo4Exception(string mensaje, Exception e): base(mensaje,e)
        {

        }
    }
}
