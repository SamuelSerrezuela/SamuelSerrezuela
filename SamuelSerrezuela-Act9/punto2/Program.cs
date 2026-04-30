using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace punto2
{
  
        class Program
        {
            private string[] vendedores;
            private float[] ventas;

        
            public void Cargar()
            {
                vendedores = new string[5];
                ventas = new float[5];
                for (int i = 0; i < vendedores.Length; i++)
                {
                    Console.Write($"ingrese el nombre del vendedor {i + 1}: ");
                    vendedores[i] = Console.ReadLine();
                    Console.Write($"ingrese el total de ventas de {vendedores[i]}: ");
                    ventas[i] = float.Parse(Console.ReadLine());
                }
            }

            
            public void OrdenarPorVentas()
            {
                for (int k = 0; k < ventas.Length - 1; k++)
                {
                    for (int f = 0; f < ventas.Length - 1 - k; f++)
                    {
                      
                        if (ventas[f] < ventas[f + 1])
                        {
                          
                            float auxVenta = ventas[f];
                            ventas[f] = ventas[f + 1];
                            ventas[f + 1] = auxVenta;

                            
                            string auxNombre = vendedores[f];
                            vendedores[f] = vendedores[f + 1];
                            vendedores[f + 1] = auxNombre;
                        }
                    }
                }
            }

            
            public void ImprimirResultados()
            {
                Console.WriteLine("\n listas de menor a mayor");
                for (int i = 0; i < vendedores.Length; i++)
                {
                    Console.WriteLine($"{i + 1}. {vendedores[i].PadRight(15)}  Las vventas: ${ventas[i]:N2}");
                }

            // utilice chat gpt en "padright" ya que no sabia que eso alinewaba a la izquierda y me parecia que quedaba mas prolijo, ademas de que me permitia alinear los numeros a la derecha

            int ultimaPos = vendedores.Length - 1;
                Console.WriteLine("\nventassssss");
                Console.WriteLine($"vendedor con menos ventas: {vendedores[ultimaPos]} (${ventas[ultimaPos]:N2})");
            }

            static void Main(string[] args)
            {
                Program empresa = new Program();
                empresa.Cargar();
                empresa.OrdenarPorVentas();
                empresa.ImprimirResultados();
                Console.ReadKey();
            }
        }
    }
