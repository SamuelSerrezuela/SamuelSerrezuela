using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Punto4
{

    /*Se ingresan por teclado tres números, si al menos uno de los valores ingresados es menor a 10,
    imprimir en pantalla la leyenda "Alguno de los números es menor a diez".   
*/
    internal class Program
    {
        static void Main(string[] args)
        {


            Console.Write("Ingrese el primer número: ");
            int n1 = int.Parse(Console.ReadLine());

            Console.Write("Ingrese el segundo número: ");
            int n2 = int.Parse(Console.ReadLine());

            Console.Write("Ingrese el tercer número: ");
            int n3 = int.Parse(Console.ReadLine());

            if (n1 < 10 || n2 < 10 || n3 < 10)
            {
                Console.WriteLine("Alguno de los números es menor a diez");
            }
            Console.ReadKey();
        }
    }
}

