using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Punto_1

/* En una empresa trabajan n empleados cuyos sueldos oscilan entre $100 y
$500, realizar un programa que lea los sueldos que cobra cada empleado e
informe cuántos empleados cobran entre $100 y $300 y cuántos cobran más
de $300. Además el programa deberá informar el importe que gasta la empresa
en sueldos al personal.*/
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n, x = 1;
            int sueldoBajo = 0; 
            int sueldoAlto = 0;  
            float sueldo, totalGasto = 0;

            Console.Write("ingrese la cantidad de empleados: ");
            n = int.Parse(Console.ReadLine());

            while (x <= n)
            {
                Console.Write($"ingrese el sueldo del empleado {x} : ");
                sueldo = float.Parse(Console.ReadLine());

                
                if (sueldo >= 100 && sueldo <= 300)
                {
                    sueldoBajo++;
                }
                else if (sueldo > 300)
                {
                    sueldoAlto++;
                }

                totalGasto += sueldo;
                x++;
            }

            
            Console.WriteLine("        Informe de Sueldos     ");
            Console.WriteLine($"Empleados que cobran entre $100 y $300: {sueldoBajo}");
            Console.WriteLine($"Empleados que cobran más de $300: {sueldoAlto}");
            Console.WriteLine($"Importe total que gasta la empresa en sueldos: ${totalGasto}");

            Console.ReadKey();
        }
    }





}
    




        