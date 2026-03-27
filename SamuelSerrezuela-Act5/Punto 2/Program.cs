using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Punto_2
{
    /*Realizar un programa que lea los lados de n triángulos, e informar:
a) De cada uno de ellos, qué tipo de triángulo es: equilátero (tres lados
iguales), isósceles (dos lados iguales), o escaleno (ningún lado igual)
b) Cantidad de triángulos de cada tipo.
c) Tipo de triángulo que posee menor cantidad.*/
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Ingrese la cantidad de triángulos a procesar: ");
            int n = int.Parse(Console.ReadLine());

            int equilateros = 0, isosceles = 0, escalenos = 0;

            for (int i = 1; i <= n; i++)
            {
                Console.Write("triangulo");
                Console.WriteLine(i);
                Console.Write("Ingrese lado 1: ");
                double lado1 = double.Parse(Console.ReadLine());
                Console.Write("Ingrese lado 2: ");
                double lado2 = double.Parse(Console.ReadLine());
                Console.Write("Ingrese lado 3: ");
                double lado3 = double.Parse(Console.ReadLine());

                
                if (lado1 == lado2 && lado2 == lado3)
                {
                    Console.WriteLine("Tipo: Equilátero");
                    equilateros++;
                }
                else if (lado1 == lado2 || lado1 == lado3 || lado2 == lado3)
                {
                    Console.WriteLine("Tipo: Isósceles");
                    isosceles++;
                }
                else
                {
                    Console.WriteLine("Tipo: Escaleno");
                    escalenos++;
                }
            }


            Console.WriteLine("- Resultados Totales -");
            Console.Write("equilateros: ");
            Console.WriteLine(equilateros);
            Console.Write("isoseles: ");
            Console.WriteLine(isosceles);
            Console.Write("escaleno: ");
            Console.WriteLine(escalenos);



            
            Console.Write("El tipo de triángulo con menor cantidad es: ");
            if (equilateros <= isosceles && equilateros <= escalenos)
            {
                Console.WriteLine("Equilátero");
            }
            else if (isosceles <= escalenos)
            {
                Console.WriteLine("Isósceles");
            }
            else
            {
                Console.WriteLine("Escaleno");
            }
            Console.ReadKey();
        }
    }
}

