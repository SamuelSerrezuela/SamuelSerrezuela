using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*Se realiza la carga de 10 valores enteros por teclado. Se desea conocer:
a) La cantidad de valores ingresados negativos.
b) La cantidad de valores ingresados positivos.
c) La cantidad de múltiplos de 15.
d) El valor acumulado de los números ingresados que son pares.*/

namespace Punto_3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int negativos = 0;
            int positivos = 0;
            int multiplos15 = 0;
            int acumuladoPares = 0;

            for (int i = 1; i <= 10; i++)
            {
                Console.Write("ingrese el valor " + i + ": ");
                int valor = int.Parse(Console.ReadLine());

                
                if (valor < 0)
                {
                    negativos++;
                }

                
                if (valor > 0)
                {
                    positivos++;
                }

                
                if (valor % 15 == 0 && valor != 0)
                {
                    multiplos15++;
                }

                

                if (valor % 2 == 0)
                {
                    acumuladoPares += valor;
                }
            }

            Console.WriteLine("--- Resultados ---");
            Console.WriteLine("Cantidad de negativos: " + negativos);
            Console.WriteLine("Cantidad de positivos: " + positivos);
            Console.WriteLine("Cantidad de múltiplos de 15: " + multiplos15);
            Console.WriteLine("Suma acumulada de pares: " + acumuladoPares);
        }
        Console.ReadKey();
    }
}
