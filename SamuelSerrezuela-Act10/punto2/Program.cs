using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*Crear una matriz de n * m filas (cargar n y m por teclado) Intercambiar la
primer fila con la segunda. Imprimir luego la matriz.*/

namespace punto2
{
    class Program
    {
        static void Main()
        {

            Console.Write("ingrese el número de filas : ");
            int n = int.Parse(Console.ReadLine());
            Console.Write("ingrese el número de columnas : ");
            int m = int.Parse(Console.ReadLine());

            int[,] matriz = new int[n, m];


            CargarMatriz(matriz);

            Console.WriteLine("\nmatriz Original:");
            ImprimirMatriz(matriz);

            IntercambiarFilas(matriz, 0, 1);

            Console.WriteLine("\nmatriz después del intercambio:");
            ImprimirMatriz(matriz);
        }


        static void CargarMatriz(int[,] mat)
        {
            for (int f = 0; f < mat.GetLength(0); f++)
            {
                for (int c = 0; c < mat.GetLength(1); c++)
                {
                    Console.Write($"elemento [{f},{c}]: ");
                    mat[f, c] = int.Parse(Console.ReadLine());
                }
            }
        }


        static void IntercambiarFilas(int[,] mat, int filaA, int filaB)
        {
            int columnas = mat.GetLength(1);
            for (int c = 0; c < columnas; c++)
            {
                int aux = mat[filaA, c];
                mat[filaA, c] = mat[filaB, c];
                mat[filaB, c] = aux;
            }
        }


        static void ImprimirMatriz(int[,] mat)
        {
            for (int f = 0; f < mat.GetLength(0); f++)
            {
                for (int c = 0; c < mat.GetLength(1); c++)
                {
                    Console.Write(mat[f, c] + "\t");
                }
                Console.WriteLine();
            }
        }
    }
}