using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*Se desea desarrollar un programa que permita registrar los nombres y las
calificaciones de 6 estudiantes. Luego de cargar los datos, se debe mostrar el
nombre del estudiante con la nota más alta, junto con su nota. Al igual que el
estudiante con la nota más baja. Informar si hay estudiantes con la misma nota
máxima o mínima.*/


namespace punto_1
{
 
        class Program
        {
            private string[] nombres;
            private float[] notas;
            private float notaMayor;
            private float notaMenor;

            public void Cargar()
            {
                nombres = new string[6];
                notas = new float[6];
                for (int i = 0; i < nombres.Length; i++)
                {
                    Console.Write($"ingrese el nombre del estudiante {i + 1}: ");
                    nombres[i] = Console.ReadLine();
                    Console.Write($"ingrese la nota de {nombres[i]}: ");
                    notas[i] = float.Parse(Console.ReadLine());
                }
            }

            public void AnalizarNotas()
            {
                
                notaMayor = notas[0];
                notaMenor = notas[0];

                
                for (int i = 1; i < notas.Length; i++)
                {
                    if (notas[i] > notaMayor) notaMayor = notas[i];
                    if (notas[i] < notaMenor) notaMenor = notas[i];
                }

                Console.WriteLine("\nresultados");

               
                Console.WriteLine($"nota Máxima: {notaMayor}");
                int cantMax = 0;
                for (int i = 0; i < notas.Length; i++)
                {
                    if (notas[i] == notaMayor)
                    {
                        Console.WriteLine($"estudiante: {nombres[i]}");
                        cantMax++;
                    }
                }
                if (cantMax > 1) Console.WriteLine("hay varios estudiantes con la misma nota maxima");

                Console.WriteLine("la nota minima es :");

               
                Console.WriteLine($"Nota Mínima: {notaMenor}");
                int cantMin = 0;
                for (int i = 0; i < notas.Length; i++)
                {
                    if (notas[i] == notaMenor)
                    {
                        Console.WriteLine($"estudiante: {nombres[i]}");
                        cantMin++;
                    }
                }
                if (cantMin > 1) Console.WriteLine("hay varios estudiantes con la misma nota mínima.");
            }

            static void Main(string[] args)
            {
                Program app = new Program();
                app.Cargar();
                app.AnalizarNotas();

               
                Console.ReadKey();
            }
        }
    }