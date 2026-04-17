using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*Pedir al usuario que ingrese las puntuaciones obtenidas en 6 partidas seguidas de
un videojuego. El programa debe:
 Mostrar la puntuación más alta y la más baja.
 Calcular el promedio de puntuación.
 Contar cuántas veces superó los 500 puntos.*/

namespace punto3
{
    class Program
    {
        int partidas = 6;
        int[] puntuacion;
        int promedio = 0;
        int puntosTotales = 0;
        int contador500 = 0; 
        int max;
        int min;

        public void juego()
        {
            puntuacion = new int[partidas];

            Console.WriteLine("ingrese las puntuaciones de las partidas ");
            for (int  i = 0;  i < partidas;  i++)
            {
                Console.Write($"ingrese el primer puntaje {i + 1} : ");
                puntuacion[i] = int.Parse( Console.ReadLine() );

                puntosTotales = puntosTotales + puntuacion[i];

                if (puntuacion[i] > 500)
                {
                    contador500 = contador500 + 1;
                }

                if (i == 0) 
                {
                    max = puntuacion[i];
                    min = puntuacion[i];
                }
                else
                {
                    if (puntuacion[i] > max)
                    {
                        max = puntuacion[i];
                    }

                    if (puntuacion[i] < min)
                    {
                        min = puntuacion[i];
                    }   
                }

                

                             
            }
            double promedio = (double)puntosTotales / partidas;

            Console.WriteLine(" resultadoss ");
            Console.WriteLine("la puntuación más alta es: " + max);
            Console.WriteLine("la puntuación más baja es: " + min);
            Console.WriteLine("el promedio es: " + promedio);
            Console.WriteLine("partidas que pasaron de los 500 puntos: " + contador500);

        }         

        

        

        static void Main(string[] args)
        {
            Program ACM = new Program();
            ACM.juego();
            Console.ReadKey();
        }
    }
}
