using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Punto1
{

    /*Realizar un programa que pida cargar una fecha cualquiera,
    luego verificar si dicha fecha corresponde a Navidad.    
*/
    internal class Program
    {
        static void Main(string[] args)
        {


            Console.Write("ingrese el día: ");
            int dia = int.Parse(Console.ReadLine());

            Console.Write("ingrese el mes: ");
            int mes = int.Parse(Console.ReadLine());

            if (dia == 25 && mes == 12)
            {
                Console.WriteLine("es Navidaad");
            }
            else
            {
                Console.WriteLine("no es navidad");
            }

            Console.ReadKey();
        }
    }
}

