using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Punto1
{
    internal class Program
    {
        static void Main(string[] args)
        /*Confeccionar un programa que permita ingresar un valor del 1 al 10 y nos
muestre la tabla de multiplicar del mismo (los primeros 13 términos)
Ejemplo: Si ingreso 3 deberá aparecer en pantalla los valores 3, 6, 9, hasta el
39.*/
        {
            Console.Write("ingrese un valor del 1 al 10: ");
            int numero = int.Parse(Console.ReadLine());
            Console.WriteLine("tabla de multiplicar del " + numero + ":");


            for (int i = 1; i <= 13; i++)
            {
                int resultado = numero * i;
                Console.WriteLine(numero + " x " + i + " = " + resultado);
            }
            Console.ReadKey();
        }
    }
}



