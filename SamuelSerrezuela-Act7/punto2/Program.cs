using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*Realizar un programa que pida la carga de dos vectores numéricos enteros de 4
elementos. Obtener la suma de los dos vectores, dicho resultado guardarlo en un
tercer vector del mismo tamaño. Sumar componente a componente.
 */

namespace punto2
{
    class Program
    {
        int[] vector1 = new int[4];
        int[] vector2 = new int[4];
        int[] vectorSuma = new int[4];

        public void cargar ()

        {
            Console.WriteLine("carga el primer vector: ");
            for (int i = 0; i < 4; i++)
            {
               
                Console.Write($"ingrese el elemento nro {i + 1}: ");
                vector1[i] = int.Parse(Console.ReadLine());
            }

            Console.WriteLine("cargar el segundo vector ");
            for(int i = 0;i < 4; i++)
            {

                Console.Write($"ingresa el elemento nro {i + 1} : ");
                vector2[i] = int.Parse(Console.ReadLine());


            }


        }

        public void suma ()
        {
            Console.WriteLine("suma de todooo ");
            for (int i = 0; i < 4; i++)
            {
                vectorSuma[i] = vector1[i] + vector2[i];
                Console.WriteLine ($"{vector1[i]} + {vector2[i]} = {vectorSuma[i]}");

            }

        }


        static void Main(string[] args)
        {
            Program OGT = new Program();
            OGT.cargar();
            OGT.suma();
            Console.ReadKey();
        }
    }
}
