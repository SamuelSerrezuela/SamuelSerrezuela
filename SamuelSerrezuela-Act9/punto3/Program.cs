using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace punto3
{
   
        class Program
        {
            private string[] nombres;
            private float[] tiempos;
            private float promedio;

            public void Cargar()
            {
                nombres = new string[5];
                tiempos = new float[5];
                for (int i = 0; i < nombres.Length; i++)
                {
                    Console.Write($"nombre del atleta {i + 1}: ");
                    nombres[i] = Console.ReadLine();
                    Console.Write($"tiempo de {nombres[i]} segundos: ");
                    tiempos[i] = float.Parse(Console.ReadLine());
                }
            }

            public void CalcularYMostrarPromedio()
            {
                float suma = 0;
                for (int i = 0; i < tiempos.Length; i++)
                {
                    suma += tiempos[i];
                }
                promedio = suma / tiempos.Length;
                Console.WriteLine($"\nel tiempo promedio de la carrera fue: {promedio} segundos.");
            }

            public void MostrarMejorPeor()
            {
                
                float mejorTiempo = tiempos[0];
                float peorTiempo = tiempos[0];
                int posMejor = 0;
                int posPeor = 0;

                for (int i = 1; i < tiempos.Length; i++)
                {
                    if (tiempos[i] < mejorTiempo)
                    {
                        mejorTiempo = tiempos[i];
                        posMejor = i;
                    }
                    if (tiempos[i] > peorTiempo)
                    {
                        peorTiempo = tiempos[i];
                        posPeor = i;
                    }
                }

                Console.WriteLine($"atleta con mejor tiempo: {nombres[posMejor]} ({mejorTiempo}s)");
                Console.WriteLine($"atleta con peor tiempo: {nombres[posPeor]} ({peorTiempo}s)");
            }

            public void SuperaronElPromedio()
            {
                Console.WriteLine("\natletas cuyo tiempo fue mayor al promedio (más lentos):");
                bool huboSuperiores = false;
                for (int i = 0; i < tiempos.Length; i++)
                {
                    if (tiempos[i] > promedio)
                    {
                        Console.WriteLine($" {nombres[i]} ({tiempos[i]}s)");
                        huboSuperiores = true;
                    }
                }
                if (!huboSuperiores) Console.WriteLine("nadie superó el promedio.");
            }

            static void Main(string[] args)
            {
                Program carrera = new Program();
                carrera.Cargar();
                carrera.CalcularYMostrarPromedio();
                carrera.MostrarMejorPeor();
                carrera.SuperaronElPromedio();

                Console.ReadKey();
            }
        }
    }