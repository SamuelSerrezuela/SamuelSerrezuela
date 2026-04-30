using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*Definir un vector donde almacenar los nombres de 5 países. Confeccionar el
algoritmo de ordenamiento alfabético.
 */



namespace punto2
{
    class Mundo 
    {
        private string[] paises;


        public void Cargar()
        {
            paises = new string[5];
            for (int i = 0; i < paises.Length; i++)
            {
                Console.Write($"Ingrese el nombre del país {i + 1}: ");
                paises[i] = Console.ReadLine();
            }
        }


        public void Ordenar()
        {
            for (int k = 0; k < paises.Length - 1; k++)
            {
                for (int f = 0; f < paises.Length - 1 - k; f++)
                {

                    if (paises[f].CompareTo(paises[f + 1]) > 0)
                    {
                        string aux = paises[f];
                        paises[f] = paises[f + 1];
                        paises[f + 1] = aux;
                    }
                }
            }
            Console.WriteLine("\nproceso de ordenamiento terminado!");
        }


        public void Imprimir()
        {
            Console.WriteLine("Lista de países ordenada:");
            for (int i = 0; i < paises.Length; i++)
            {
                Console.WriteLine($"{i + 1}. {paises[i]}");
            }
        }

        static void Main(string[] args)
        {

            Mundo acm = new Mundo();
            acm.Cargar();
            acm.Ordenar();
            acm.Imprimir();

            Console.ReadKey();
        }
    }
}
