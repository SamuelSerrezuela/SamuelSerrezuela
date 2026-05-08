using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace punto1
/*Crear una matriz de 2 filas y 5 columnas. Realizar la carga de
componentes por columna (es decir primero ingresar toda la primer
columna, luego la segunda columna y así sucesivamente)
Imprimir luego la matriz.*/



{
    class filas
    {

        static void Main()
        {
           
            int filas = 2;
            int columnas = 5;
            int[,] matriz = new int[filas, columnas];

            
            CargarMatrizPorColumna(matriz);
            ImprimirMatriz(matriz);
        }

        
        static void CargarMatrizPorColumna(int[,] mat)
        {
            
            for (int c = 0; c < mat.GetLength(1); c++)
            {
                
                for (int f = 0; f < mat.GetLength(0); f++)
                {
                    Console.Write($"ingresa valor para (Fila {f}, Columna {c}): ");
                    mat[f, c] = int.Parse(Console.ReadLine());
                }
            }
        }

        
        static void ImprimirMatriz(int[,] mat)
        {
            Console.WriteLine("\nvisualización de la matriz:");
            for (int f = 0; f < mat.GetLength(0); f++)
            {
                for (int c = 0; c < mat.GetLength(1); c++)
                {
                    Console.Write(mat[f, c] + "\t");
                }
                Console.WriteLine(); 
         
            }

            Console.ReadKey();
        }


    }
}



