using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*Crear una matriz de n * m filas (cargar n y m por teclado) Imprimir los
cuatro valores que se encuentran en los vértices de la misma (mat[0][0]
etc.)*/

namespace punto3
{
    class Program
    {

        static int n, m;



        public void Cargar(int[,] mat)
        {
            for (int f = 0; f < n; f++)
            {
                for (int c = 0; c < m; c++)
                {
                    Console.Write($"Dato [{f},{c}]: ");
                    mat[f, c] = int.Parse(Console.ReadLine());
                }
            }
        }

        public void Mostrar(int[,] mat)
        {
            Console.WriteLine("\nMatriz completa:");
            for (int f = 0; f < n; f++)
            {
                for (int c = 0; c < m; c++)
                {
                    Console.Write(mat[f, c] + " ");
                }
                Console.WriteLine();
            }
        }

        public void MostrarVertices(int[,] mat)
        {
            Console.WriteLine("\nLos cuatro vértices son:");
            Console.WriteLine("Arriba-Izquierda: " + mat[0, 0]);
            Console.WriteLine("Arriba-Derecha: " + mat[0, m - 1]);
            Console.WriteLine("Abajo-Izquierda: " + mat[n - 1, 0]);
            Console.WriteLine("Abajo-Derecha: " + mat[n - 1, m - 1]);
        }

        public void Main()
        {
            Console.Write("Filas: ");
            n = int.Parse(Console.ReadLine());
            Console.Write("Columnas: ");
            m = int.Parse(Console.ReadLine());

            int[,] matriz = new int[n, m];

            Cargar(matriz);
            Mostrar(matriz);
            MostrarVertices(matriz);


            Console.ReadKey();
        }
    }
}
