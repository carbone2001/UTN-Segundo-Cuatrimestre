using System;

namespace ejercicio13
{
    class Conversor
    {
        public static string DecimalBinario(double input)
        {
            int entero = (int)input;
            string resultado = "";
            while (entero != 0)
            {
                resultado = (entero % 2).ToString() + resultado;//Siempre se agregara el nuevo al principio (escritura de der. a izq.)
                entero = entero / 2;
            }
            return resultado;
        }
        public static double BinarioDecimal(string input)
        {
            double resultado = 0;

            for (int i = 1; i <= input.Length; i++)
            {
                ///El NUMERO de la POSICION i-1 se lo multiplica por 2 a la potencia de (la longitud del string menos el numero de iteracion)
                resultado += int.Parse(input[i - 1].ToString()) * (int)(Math.Pow(2, (input.Length - i)));
            }
            return resultado;
        }
    }
}
