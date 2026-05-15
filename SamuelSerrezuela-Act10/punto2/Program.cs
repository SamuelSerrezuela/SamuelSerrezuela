using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


/*Crear una matriz de n * m filas (cargar n y m por teclado) Intercambiar la

primer fila con la segunda. Imprimir luego la matriz.
 
 */

namespace punto2
{
    internal class Program
    {
        private int[,] matriz;
        private int n, m;

        

        public void cargar()
        {
            Console.Write("ingrese cantidad de filas (n): ");
            n = int.Parse(Console.ReadLine());
            Console.Write("ingrese cantidad de columnas (m): ");
            m = int.Parse(Console.ReadLine());

            matriz = new int[n, m];

            for (int f = 0; f < n; f++)
            {
                for (int c = 0; c < m; c++)
                {
                    Console.Write($"ingrese componente (ffila {f}, columna {c}): ");
                    matriz[f, c] = int.Parse(Console.ReadLine());
                }
            }
        }

        public void intercambiarFilas()
        {
            
            if (n >= 2)
            {
                for (int c = 0; c < m; c++)
                {
                    
                    int ayuda = matriz[0, c];
                    matriz[0, c] = matriz[1, c];
                    matriz[1, c] = ayuda;
                }
            }
            else
            {
                Console.WriteLine("\nno se puede intercambiar: la matriz debe tener al menos 2 filas.");
            }
        }

        public void imprimir()
        {
            Console.WriteLine("\nMatriz actual:");
            for (int f = 0; f < n; f++)
            {
                for (int c = 0; c < m; c++)
                {
                    Console.Write(matriz[f, c] + "\t");
                }
                Console.WriteLine();
            }
        }
        static void Main(string[] args)
        {
            Program pv = new Program();
            pv.cargar();
            pv.intercambiarFilas();
            pv.imprimir();
            Console.ReadKey();
        }

    }
}