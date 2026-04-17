using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/* Cargar un vector de 10 elementos y verificar posteriormente si el mismo está
ordenado de menor a mayor y de mayor a menor.
 */


namespace punto4
{
    class Program
    {
        int[] elementos;
        int contMayor = 0; 
        int contMenor = 0;
        int total = 10;

        public void recarga()
        {
            elementos = new int[total];
            Console.WriteLine("rellene el vector con 10 numeros");

            
            for (int i = 0; i < total; i++)
            {
                Console.Write($"ingrese el valor nro {i + 1} : ");
                elementos[i] = int.Parse(Console.ReadLine());
            }

            
            for (int i = 0; i < total - 1; i++)
            {
                if (elementos[i] <= elementos[i + 1])
                {
                    contMayor = contMayor + 1;
                }

                if (elementos[i] >= elementos[i + 1])
                {
                    contMenor = contMenor + 1;
                }
            }

            Console.WriteLine("diagnóstico:");

            if (contMayor == 9)
            {
                Console.WriteLine("el vector está ordenado de menor a mayor");
            }
            else if (contMenor == 9)
            {
                Console.WriteLine("el vector está ordenado de mayor a menor");
            }
            else
            {
                Console.WriteLine("el vector está desordenado");
            }
        }

        static void Main(string[] args)
        {
            Program yts = new Program();
            yts.recarga();
            Console.ReadKey();
        }
    }
}
