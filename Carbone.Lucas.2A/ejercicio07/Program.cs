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



            if (anio != DateTime.Now.Year) //si el anio ingresado no es igual al anio actual
            {
                diaAux = dia;
                diaAux2 = DateTime.Now.Day;

                //Descartar dias del nacimiento que faltan para llegar al anio proximo
                for (int j = mes; j <= 12; j++)//Desde el mes ingresado hasta fin de ese anio
                {
                    switch (j)
                    {
                        case 1:
                            contadorDias = contadorDias + 31;
                            break;
                        case 2:
                            if (DateTime.IsLeapYear(anio))
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

                }
                contadorDias = contadorDias - diaAux;//Descartamos los dias de mas de ese mes
                diaAux = 0;//Limpiamos la variable

                ///Descartar dias del anio presente
                diaAux = DateTime.Now.Day;
                contadorDias = contadorDias + diaAux;//Sumamos los dias que van del mes actual
                for (int j = 1; j < DateTime.Now.Month; j++)//Del mes 1 hasta un mes antes del actual de este anio
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

                for (int i = anio + 1; i < DateTime.Now.Year; i++)//Contemplamos los anios que hay entre la ingresada y la actual sin contar el anio de inicio y el final
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
            }
            else //El anio ingresado es el actual
            {
                diaAux = dia;
                diaAux2 = DateTime.Now.Day;
                if (mes == DateTime.Now.Month)//Si el mes ingresado es el mismo que el actual
                {
                    contadorDias = diaAux2 - diaAux;
                }
                else if (mes < DateTime.Now.Month)
                {
                    contadorDias = contadorDias + diaAux2 - diaAux;//Sumamos los dias transcurridos en este mes y restamos los transcurridos en el mes ingresado
                    for (int j = mes; j < DateTime.Now.Month; j++)
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
                        diaAux2 = 0;
                    }
                }

            }
            Console.WriteLine("Desde {0}/{1}/{2} hasta la fecha de hoy {3}/{4}/{5}, han pasado {6} dias ", dia, mes, anio, DateTime.Now.Day, DateTime.Now.Month, DateTime.Now.Year, contadorDias);
            Console.ReadLine();
        }
    }
}






//for ( int i = anio; i <= DateTime.Now.Year; i++)
//{

//Console.WriteLine("Desde {0}/{1}/{2} hasta la hoy {3}/{4}/{5}, han pasado {6} dias ", dia, mes, anio, DateTime.Now.Day, DateTime.Now.Month, DateTime.Now.Year, contadorDias);
//}


