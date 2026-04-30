using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
/*Cargar un vector de n elementos de tipo entero. Ordenar posteriormente el vector
(el orden lo pueden elegir ustedes)
 */


  namespace punto3
  {


        class OrdenamientoEnteros
        {
            private int[] vector;

           
            public void Cargar()
            {
                Console.Write("ingresee la cantidad de elementos (n): ");
                int n = int.Parse(Console.ReadLine());
                vector = new int[n];

                for (int i = 0; i < vector.Length; i++)
                {
                    Console.Write($"ingrese el valor para la posición [{i}]: ");
                    vector[i] = int.Parse(Console.ReadLine());
                }
            }

            
            public void Ordenar()
            {
                int aux;
                for (int k = 0; k < vector.Length - 1; k++)
                {
                    for (int f = 0; f < vector.Length - 1 - k; f++)
                    {
                        if (vector[f] > vector[f + 1])
                        {
                            
                            aux = vector[f];
                            vector[f] = vector[f + 1];
                            vector[f + 1] = aux;
                        }
                    }
                }
                Console.WriteLine("\nvector ordenado.");
            }

            
            public void Imprimir()
            {
                Console.WriteLine("contenido del vector:");
                for (int i = 0; i < vector.Length; i++)
                {
                    Console.Write(vector[i] + " ");
                }
                Console.WriteLine(); 
            }

            static void Main(string[] args)
            {
                OrdenamientoEnteros op = new OrdenamientoEnteros();
                op.Cargar();
                op.Ordenar();
                op.Imprimir();
                Console.ReadKey();
            }
        }
    }

