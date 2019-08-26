using System;

namespace LibreriaEjercicios
{
    public class Validacion
    {
        public static bool Validar(int valor, int min, int max)
        {
            bool validacion = true;
            if (valor > max || valor < min)
            {
                validacion = false;
            }
            return validacion;
        }
    }
    public class ValidarRespuesta
    {
        public static bool ValidaS_N(char c)
        {
            bool respuesta = true;
            if (c != 's')
            {
                respuesta = false;
            }
            return respuesta;
        }
    }
    public class Conversor
    {

        public static string DecimalBinario(double input)
        {
            int entradaAux = (int)(input);
            double decimales;
            int contador = 0;
            double decimalReferencia;
            int resto;
            string respuesta = "";
            string respuestaDecimales = "";
            decimales = input - entradaAux;
            while (entradaAux > 0)
            {
                resto = entradaAux % 2;
                entradaAux = entradaAux / 2;
                if (resto == 1)
                {
                    respuesta = "1" + respuesta;//Los nuevo numeros deben ir por detras de los antiguos
                }
                else
                {
                    respuesta = "0" + respuesta;//Los nuevo numeros deben ir por detras de los antiguos
                }

            }
            if (decimales > 1)
            {
                decimalReferencia = decimales - 1;
                respuesta = respuesta + ".";

            }
            else if (decimales == 0)
            {
                decimalReferencia = decimales;
                respuesta = respuesta + ".0";
            }
            else
            {
                decimalReferencia = decimales;
                respuesta = respuesta + ".";
            }

            while ((decimalReferencia > 0) && contador < 20)
            {

                decimales = decimales * 2;

                if (decimales >= 1)
                {
                    decimales = decimales - 1;
                    respuestaDecimales = respuestaDecimales + "1";
                }
                else
                {
                    respuestaDecimales = respuestaDecimales + "0";
                }
                if (decimales == decimalReferencia || decimales == 0)
                {
                    break;
                }
                contador++;
            }
            respuesta = respuesta + respuestaDecimales;
            return respuesta;
        }
        public static double BinarioDecimal(string input)
        {
            double entradaDouble = double.Parse(input);
            int entradaInt = (int)entradaDouble;
            int suma = 0;
            int decimalExponenciado;
            int isAOne;
            for (int i = input.Length - 3; i >= 0; i--)
            {
                decimalExponenciado = (int)(Math.Pow(10, i));
                isAOne = (entradaInt - decimalExponenciado);
                if (isAOne >= 0)
                {
                    suma += (int)(Math.Pow(10, i));
                    entradaInt = isAOne;
                }
            }
            return suma;
        }
    }

    public class CalculoDeArea
    {
        public static double CalcularCuadrado(double lado)
        {
            double resultado;
            resultado = Math.Pow(lado, 2);
            return resultado;
        }
        public static double CalcularTriangulo(double baseT, double altura)
        {
            double resultado;
            resultado = (baseT * altura) / 2;
            return resultado;
        }
        public static double CalcularCirculo(double radio)
        {
            double resultado;
            resultado = Math.PI * Math.Pow(radio, 2);
            return resultado;
        }
    }

    public class Calculadora
    {
        private class Validar
        {
            public static bool Division(double input)
            {
                if (input == 0)
                {
                    return false;
                }
                return true;
            }
        }
        public static double Calcular(double num1, double num2, char signo)
        {
            double resultado = 0;
            switch (signo)
            {

                case '+':
                    resultado = num1 + num2;
                    break;
                case '-':
                    resultado = num1 - num2;
                    break;
                case '/':
                    if (Validar.Division(num2))
                    {
                        resultado = num1 / num2;
                    }
                    else
                    {
                        Console.WriteLine("Error. No se puede dividir por 0");
                        Console.ReadLine();
                    }
                    break;
                case '*':
                    resultado = num1 * num2;
                    break;
                default:
                    Console.WriteLine("Error. El signo ingresado es invalido.");
                    Console.ReadLine();
                    break;
            }


            return resultado;
        }

    }

}
