using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/* Desarrollar un programa que permita ingresar un vector de 8 elementos, e informe:
El valor acumulado de todos los elementos del vector.
El valor acumulado de los elementos del vector que sean mayores a 36.
Cantidad de valores mayores a 50.
 */

namespace punto1
{
    class Program
    {
        
        int[] elementos;
        int sumaTotal = 0;
        int suma36 = 0;
        int conta50 = 0;

        public void cargarElementos()
        {
            
            elementos = new int[8];

            
            for (int i = 0; i < 8; i++)
            {
                Console.Write($"Ingresa el número {i + 1}: ");
                elementos[i] = int.Parse(Console.ReadLine());
            }
        }

        public void calculos()
        {
            for (int i = 0; i < 8; i++)
            {
                sumaTotal = sumaTotal + elementos[i];

                if (elementos[i] > 36)
                {
                    suma36 = suma36 + elementos[i];
                }

                if (elementos[i] > 50)
                {
                    conta50 = conta50 + 1;
                }
            }

            
            Console.WriteLine("RESULTADOS");
            Console.WriteLine("suma total: " + sumaTotal);
            Console.WriteLine("suma de mayores a 36: " + suma36);
            Console.WriteLine("cantidad de mayores a 50: " + conta50);
        }

        static void Main(string[] args)
        {
            Program PRM = new Program();
            PRM.cargarElementos();
            PRM.calculos();
            Console.ReadKey();
        }
    }
}




