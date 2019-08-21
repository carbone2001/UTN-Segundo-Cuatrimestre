using System;

namespace ejercicio_07
{
    class Program
    {
        static void Main(string[] args)
        {
            int dia;
            int mes;
            int anio;

            int diaAux;
            int diaAux2;
            int contadorDias = 0;
            Console.Title = "Ejercicio 7";
            Console.WriteLine("Ingrese fecha de nacimiento ");
            Console.Write("Dia: ");
            dia = int.Parse(Console.ReadLine());
            diaAux = dia;
            Console.Write("Mes: ");
            mes = int.Parse(Console.ReadLine());
            Console.Write("Anio: ");
            anio = int.Parse(Console.ReadLine());

            //Descartar dias del nacimiento que faltan para llegar al anio proximo

            if (anio != DateTime.Now.Year)
            {
                for (int j = mes; j <= 12; j++)
                {
                    switch (j)
                    {
                        case 1:
                            contadorDias = contadorDias + 31 - diaAux;
                            break;
                        case 2:
                            if (DateTime.IsLeapYear(anio))
                            {
                                contadorDias = contadorDias + 29 - diaAux;
                            }
                            else
                            {
                                contadorDias = contadorDias + 28 - diaAux;
                            }
                            break;
                        case 3:
                            contadorDias = contadorDias + 31 - diaAux;
                            break;
                        case 4:
                            contadorDias = contadorDias + 30 - diaAux;
                            break;
                        case 5:
                            contadorDias = contadorDias + 31 - diaAux;
                            break;
                        case 6:
                            contadorDias = contadorDias + 30 - diaAux;
                            break;
                        case 7:
                            contadorDias = contadorDias + 31 - diaAux;
                            break;
                        case 8:
                            contadorDias = contadorDias + 31 - diaAux;
                            break;
                        case 9:
                            contadorDias = contadorDias + 30 - diaAux;
                            break;
                        case 10:
                            contadorDias = contadorDias + 31 - diaAux;
                            break;
                        case 11:
                            contadorDias = contadorDias + 30 - diaAux;
                            break;
                        case 12:
                            contadorDias = contadorDias + 31 - diaAux;
                            break;
                        default:
                            Console.WriteLine("\nHa ocurrido un error\n");
                            break;
                    }
                    diaAux = 0;
                }
                ///Descartar dias del anio presente
                diaAux = DateTime.Now.Day;
                for (int j = 1; j <= DateTime.Now.Month; j++)
                {
                    switch (j)
                    {
                        case 1:
                            contadorDias = contadorDias + 31 - diaAux;
                            break;
                        case 2:
                            if (DateTime.IsLeapYear(DateTime.Now.Year))
                            {
                                contadorDias = contadorDias + 29 - diaAux;
                            }
                            else
                            {
                                contadorDias = contadorDias + 28 - diaAux;
                            }
                            break;
                        case 3:
                            contadorDias = contadorDias + 31 - diaAux;
                            break;
                        case 4:
                            contadorDias = contadorDias + 30 - diaAux;
                            break;
                        case 5:
                            contadorDias = contadorDias + 31 - diaAux;
                            break;
                        case 6:
                            contadorDias = contadorDias + 30 - diaAux;
                            break;
                        case 7:
                            contadorDias = contadorDias + 31 - diaAux;
                            break;
                        case 8:
                            contadorDias = contadorDias + 31 - diaAux;
                            break;
                        case 9:
                            contadorDias = contadorDias + 30 - diaAux;
                            break;
                        case 10:
                            contadorDias = contadorDias + 31 - diaAux;
                            break;
                        case 11:
                            contadorDias = contadorDias + 30 - diaAux;
                            break;
                        case 12:
                            contadorDias = contadorDias + 31 - diaAux;
                            break;
                        default:
                            Console.WriteLine("\nHa ocurrido un error\n");
                            break;
                    }
                    diaAux = 0;
                }
            }
            else
            {
                diaAux = dia;
                diaAux2 = DateTime.Now.Day;
                if (mes == DateTime.Now.Month)
                {
                    contadorDias = diaAux2 - diaAux;
                }
                else
                {
                    for (int j = mes; j <= DateTime.Now.Month; j++)
                    {
                        switch (j)
                        {
                            case 1:
                                contadorDias = contadorDias + 31;
                                break;
                            case 2:
                                if (DateTime.IsLeapYear(DateTime.Now.Year))
                                {
                                    contadorDias = contadorDias + 29;
                                }
                                else
                                {
                                    contadorDias = contadorDias + 28;
                                }
                                break;
                            case 3:
                                contadorDias = contadorDias + 31;
                                break;
                            case 4:
                                contadorDias = contadorDias + 30;
                                break;
                            case 5:
                                contadorDias = contadorDias + 31;
                                break;
                            case 6:
                                contadorDias = contadorDias + 30;
                                break;
                            case 7:
                                contadorDias = contadorDias + 31;
                                break;
                            case 8:
                                contadorDias = contadorDias + 31;
                                break;
                            case 9:
                                contadorDias = contadorDias + 30;
                                break;
                            case 10:
                                contadorDias = contadorDias + 31;
                                break;
                            case 11:
                                contadorDias = contadorDias + 30;
                                break;
                            case 12:
                                contadorDias = contadorDias + 31;
                                break;
                            default:
                                Console.WriteLine("\nHa ocurrido un error\n");
                                break;
                        }
                        diaAux = 0;
                    }
                    contadorDias = contadorDias - diaAux - diaAux2;
                }


            }

            for (int i = anio + 1; i <= DateTime.Now.Year - 1; i++)
            {
                if (DateTime.IsLeapYear(DateTime.Now.Year))
                {
                    contadorDias = contadorDias + 366;
                }
                else
                {
                    contadorDias = contadorDias + 365;
                }
            }

            Console.WriteLine("Desde {0}/{1}/{2} hasta la fecha de hoy {3}/{4}/{5}, han pasado {6} dias ", dia, mes, anio, DateTime.Now.Day, DateTime.Now.Month, DateTime.Now.Year, contadorDias);


        }
    }
}






//for ( int i = anio; i <= DateTime.Now.Year; i++)
//{

//Console.WriteLine("Desde {0}/{1}/{2} hasta la hoy {3}/{4}/{5}, han pasado {6} dias ", dia, mes, anio, DateTime.Now.Day, DateTime.Now.Month, DateTime.Now.Year, contadorDias);
//}


