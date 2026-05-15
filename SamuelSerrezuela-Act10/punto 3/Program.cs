using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*Crear una matriz de n * m filas (cargar n y m por teclado) Imprimir los
cuatro valores que se encuentran en los vértices de la misma (mat[0][0]
etc.)   */



namespace punto3
{
    internal class Program
    {
        private int[,] matriz;
        private int n, m;

        

        public void Cargar()
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
                    Console.Write($"ingresa el componente (Fila {f}, columna {c}): ");
                    matriz[f, c] = int.Parse(Console.ReadLine());
                }
            }
        }

        public void ImprimirVertices()
        {
            Console.WriteLine("\nVertices:");

            
            Console.WriteLine("[" + matriz[0, 0] + "]");          
            Console.WriteLine("[" + matriz[0, m - 1] + "]");       
            Console.WriteLine("[" + matriz[n - 1, 0] + "]");      
            Console.WriteLine("[" + matriz[n - 1, m - 1] + "]");   
        }



        static void Main(string[] args)
        {
            Program cp = new Program();
            cp.Cargar();
            cp.ImprimirVertices();
            Console.ReadKey();
        }
    }

}