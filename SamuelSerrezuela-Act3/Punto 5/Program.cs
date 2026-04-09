using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Punto5
{

    /*Escribir un programa que pida ingresar la coordenada de un punto en el plano,
     * es decir dos valores enteros x e y (distintos a cero).
     * Posteriormente imprimir en pantalla en que cuadrante se ubica dicho punto.
     * (1º Cuadrante si x > 0 Y y > 0 , 2º Cuadrante: x < 0 Y y > 0).     
*/
    internal class Program
    {
        static void Main(string[] args)
        {

            Console.Write("ingrese el valor de x: ");
            int x = int.Parse(Console.ReadLine());

            Console.Write("ingrese el valor de y: ");
            int y = int.Parse(Console.ReadLine());

            if (x > 0 && y > 0)
            {
                Console.WriteLine("el punto se encuentra en el 1º cuadrante.");
            }
            else if (x < 0 && y > 0)
            {
                Console.WriteLine("el punto se encuentra en el 2º cuadrante");
            }
            else if (x < 0 && y < 0)
            {
                Console.WriteLine("el punto se encuentra en el 3º cuadrante");
            }
            else if (x > 0 && y < 0)
            {
                Console.WriteLine("el punto se encuentra en el 4º cuadrante");
            }
            else
            {
                Console.WriteLine("el punto no pertenece a ningún cuadrante");
            }
            Console.ReadKey();
        }
    }
}
