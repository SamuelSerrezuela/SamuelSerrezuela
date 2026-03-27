using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Punto_2

/*Realizar un programa que imprima 25 términos de la serie 11 - 22 - 33 - 44, etc.
(No se ingresan valores por teclado) */
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int i = 1;      
            int valor = 11; 

            while (i <= 25)
            {
                Console.Write(valor);

                
                if (i < 25)
                {
                    Console.Write("     ");
                }

                valor += 11; 
                i++;         
            }

            Console.WriteLine();

            Console.ReadKey();
        }
    }
}







