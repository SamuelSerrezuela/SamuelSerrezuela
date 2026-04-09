using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Punto2
{

    /*
     Se ingresan tres valores por teclado,
    si todos son iguales se imprime la suma del primero con el segundo
    y a este resultado se lo multiplica por el tercero.

*/
    internal class Program
    {
        static void Main(string[] args)
        {

            Console.Write("ingrese el primer valor: ");
            int n1 = int.Parse(Console.ReadLine());

            Console.Write("ingrese el segundo valor: ");
            int n2 = int.Parse(Console.ReadLine());

            Console.Write("ingrese el tercer valor: ");
            int n3 = int.Parse(Console.ReadLine());

            if (n1 == n2 && n2 == n3)

            {
                int resultadoSum = (n1 + n2);
                Console.WriteLine("resultado de la suma de los 2 primeros numeros : " + resultadoSum);
                int resultado = (n1 + n2) * n3;
                Console.WriteLine("resultado total: " + resultado);
            }
            else
            {
                int resultadoSum = (n1 + n2);
                Console.WriteLine("resultado de la suma de los 2 primeros numeros : " + resultadoSum);
                int resultado = (n1 + n2) * n3;
                Console.WriteLine("resultado total: " + resultado);
                Console.WriteLine("los valores no son iguales");
                
            }
            Console.ReadKey();
            
        }
    }
}

 