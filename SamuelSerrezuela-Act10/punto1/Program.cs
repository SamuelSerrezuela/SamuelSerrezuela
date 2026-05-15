using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*Crear una matriz de 2 filas y 5 columnas. Realizar la carga de
componentes por columna (es decir primero ingresar toda la primer
columna, luego la segunda columna y así sucesivamente)
Imprimir luego la matriz.
 */



namespace punto1
{
    internal class Program
    {
        
        private int[,] matriz;

        

        public void Cargar()
        {
            
            matriz = new int[2, 5];
            Console.WriteLine("cargar la matriz por columnas:");

            
            for (int c = 0; c < 5; c++)
            {
                
                for (int f = 0; f < 2; f++)
                {
                    Console.Write($"ingresa componente (fila {f}, columna {c}): ");
                    string linea = Console.ReadLine();
                    matriz[f, c] = int.Parse(linea);
                }
                Console.WriteLine("----------   ");
            }
        }

        public void Imprimir()
        {
            Console.WriteLine("\nmatriz completa:");
            for (int f = 0; f < 2; f++)
            {
                for (int c = 0; c < 5; c++)
                {
                    Console.Write(matriz[f, c] + " ");
                }
                
                Console.WriteLine();
            }
        }

        static void Main(string[] args)
        {
            Program pv = new Program();
            pv.Cargar();
            pv.Imprimir();
            Console.ReadKey();
        }
    }
}