using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*Cargar en un vector los nombres de 5 países y en otro vector paralelo la cantidad de
habitantes de este. Ordenar alfabéticamente e imprimir los resultados. Por último
ordenar con respecto a la cantidad de habitantes (de mayor a menor) e imprimir
nuevamente.*/


namespace punto4
{
        class Program
        {
            private string[] paises;
            private long[] habitantes;

            public void Cargar()
            {
                paises = new string[5];
                habitantes = new long[5];
                for (int i = 0; i < paises.Length; i++)
                {
                    Console.Write($"ingrese el nombre del país {i + 1}: ");
                    paises[i] = Console.ReadLine();
                    Console.Write($"ingrese la cantidad de habitantes de {paises[i]}: ");
                    habitantes[i] = long.Parse(Console.ReadLine());
                }
            }

            
            public void OrdenarPorNombre()
            {
                for (int k = 0; k < paises.Length - 1; k++)
                {
                    for (int f = 0; f < paises.Length - 1 - k; f++)
                    {
                        if (paises[f].CompareTo(paises[f + 1]) > 0)
                        {
                            
                            string auxPais = paises[f];
                            paises[f] = paises[f + 1];
                            paises[f + 1] = auxPais;

                            
                            long auxHab = habitantes[f];
                            habitantes[f] = habitantes[f + 1];
                            habitantes[f + 1] = auxHab;
                        }
                    }
                }
            }

           
            public void OrdenarPorHabitantes()
            {
                for (int k = 0; k < habitantes.Length - 1; k++)
                {
                    for (int f = 0; f < habitantes.Length - 1 - k; f++)
                    {
                       
                        if (habitantes[f] < habitantes[f + 1])
                        {
                           
                            long auxHab = habitantes[f];
                            habitantes[f] = habitantes[f + 1];
                            habitantes[f + 1] = auxHab;

                            
                            string auxPais = paises[f];
                            paises[f] = paises[f + 1];
                            paises[f + 1] = auxPais;
                        }
                    }
                }
            }

            public void Imprimir(string mensaje)
            {
                Console.WriteLine($"\n {mensaje} ");
                for (int i = 0; i < paises.Length; i++)
                {
                    Console.WriteLine($"país: {paises[i].PadRight(15)}  habitantes: {habitantes[i]:N0}");
                }
            }

            static void Main(string[] args)
            {
                Program app = new Program();
                app.Cargar();

                app.OrdenarPorNombre();
                app.Imprimir("orden alfabeticp");

                app.OrdenarPorHabitantes();
                app.Imprimir("orden por poblacion");

                Console.ReadKey();
            }
        }
    }



