using System;


namespace ejercicio19
{
    class Program
    {
        static void Main(string[] args)
        {
            Sumador s1 = new Sumador();
            Sumador s2 = new Sumador();
            long resultado;
            string resultadoStr;
            resultado = s1.Sumar(21, 21);
            Console.WriteLine("Primer resultado: {0} CantidadSumas: {1}", resultado, s1.cantidadSumas);
            resultadoStr = s1.Sumar("21", "21");
            Console.WriteLine("Primer resultadoStr: {0} CantidadSumas: {1}", resultadoStr, s1.cantidadSumas);

            resultado = s2.Sumar(21, 21);
            Console.WriteLine("Segundo resultado: {0} CantidadSumas: {1}", resultado, s2.cantidadSumas);
            resultadoStr = s2.Sumar("21", "21");
            Console.WriteLine("Segundo resultadoStr: {0} CantidadSumas: {1}", resultadoStr, s2.cantidadSumas);

            Console.WriteLine("S1 y S2 tiene misma cantidad de suma: {0}", s1 | s2);
            Console.WriteLine("s1+s2 en cantidad de suma es: {0}", s1 + s2);
            Console.Read();

        }
    }
}
