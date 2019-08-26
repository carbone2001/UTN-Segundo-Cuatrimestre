using System;

namespace ejercicio08
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "Ejercicio 8";
            float valorHora;
            string nombre;
            int antiguedad;
            byte horasMes;
            double sueldoBruto;
            double sueldoNeto;
            double descuento;
            char rta;
            do
            {
                Console.Write("Ingerse el valor de la hora: ");
                valorHora = float.Parse(Console.ReadLine());
                Console.Write("Ingrese el nombre del empleado: ");
                nombre = Console.ReadLine();
                Console.Write("Ingrese la antiguedad: ");
                antiguedad = int.Parse(Console.ReadLine());
                Console.WriteLine("Ingrese la cantidad de horas hechas en el mes: ");
                horasMes = byte.Parse(Console.ReadLine());
                sueldoBruto = (valorHora * horasMes) + (antiguedad * 150);
                descuento = (sueldoBruto * 0.13);
                sueldoNeto = (sueldoBruto - descuento);
                Console.Write("\nNombre del empleado: {0}\nHoras trbajadas: {1}\nAntiguedad: {2} anios\nValor de hora: {3}\n Sueldo bruto: {4}\n Sueldo Neto: {5}\n Descuentos totales: {6} ", nombre, horasMes, antiguedad, valorHora, sueldoBruto, sueldoNeto, descuento);

                Console.WriteLine("Desea seguir agregando empleados? s/n");
                rta = char.Parse(Console.ReadLine());
            } while (rta == 's');
        }
    }
}
