using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Punto_3

/*Realizar un programa que acumule (sume) valores ingresados por teclado hasta
ingresar el 9999 (no sumar dicho valor, indica que ha finalizado la carga). Imprimir el
valor acumulado e informar si dicho valor es cero, mayor a cero o menor a cero.*/
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int suma = 0;
            int valor;

            Console.WriteLine("ingrese valores (9999 para finalizar):");
            valor = int.Parse(Console.ReadLine());

            while (valor != 9999)
            {
                suma += valor; 

                
                valor = int.Parse(Console.ReadLine());
            }

            Console.WriteLine($"el valor acumulado es: {suma}");

           
            if (suma == 0)
            {
                Console.WriteLine("el valor es cero.");
            }
            else if (suma > 0)
            {
                Console.WriteLine("el valor es mayor a cero.");
            }
            else
            {
                Console.WriteLine("el valor es menor a cero.");
                    }

            Console.ReadKey();
        }
    }
}

                    
           
    

