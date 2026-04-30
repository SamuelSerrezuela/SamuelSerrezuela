using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace punto4
{ 

    class Program
    {
        private string[] nombres;
        private float[] puntajes;

        public void Cargar()
        {
            nombres = new string[6];
            puntajes = new float[6];
            for (int i = 0; i < nombres.Length; i++)
            {
                Console.Write($"nombre del docente {i + 1}: ");
                nombres[i] = Console.ReadLine();
                Console.Write($"puntaje de {nombres[i]} (1-10): ");
                puntajes[i] = float.Parse(Console.ReadLine());
            }
        }

        public void MostrarExtremos()
        {
            float mayor = puntajes[0];
            float menor = puntajes[0];
            int posMayor = 0;
            int posMenor = 0;

            for (int i = 1; i < puntajes.Length; i++)
            {
                if (puntajes[i] > mayor)
                {
                    mayor = puntajes[i];
                    posMayor = i;
                }
                if (puntajes[i] < menor)
                {
                    menor = puntajes[i];
                    posMenor = i;
                }
            }
            Console.WriteLine("\ncalificaciones extremas ---");
            Console.WriteLine($"docente con calificación mas alta: {nombres[posMayor]} ({mayor})");
            Console.WriteLine($"ddocente con calificación mas baja: {nombres[posMenor]} ({menor})");
        }

        public void OrdenarMayorAMenor()
        {
            for (int k = 0; k < puntajes.Length - 1; k++)
            {
                for (int f = 0; f < puntajes.Length - 1 - k; f++)
                {
                    if (puntajes[f] < puntajes[f + 1])
                    {
                       
                        float auxPuntaje = puntajes[f];
                        puntajes[f] = puntajes[f + 1];
                        puntajes[f + 1] = auxPuntaje;

                        
                        string auxNombre = nombres[f];
                        nombres[f] = nombres[f + 1];
                        nombres[f + 1] = auxNombre;
                    }
                }
            }

            Console.WriteLine("\n lista ordenada de mayor a menor:");
            for (int i = 0; i < nombres.Length; i++)
            {
                Console.WriteLine($"{nombres[i].PadRight(15)} - el puntaje: {puntajes[i]}");
            }
        }

        public void ContarAprobados()
        {
            int aprobados = 0;
            int desaprobados = 0;

            for (int i = 0; i < puntajes.Length; i++)
            {
                if (puntajes[i] >= 6)
                {
                    aprobados++;
                }
                else
                {
                    desaprobados++;
                }
            }

            Console.WriteLine("\n-resume final-");
            Console.WriteLine($"cantidad de docentes que aprobaron: {aprobados}");
            Console.WriteLine($"cantidad de docentes que desaprobaron: {desaprobados}");
        }

        static void Main(string[] args)
        {
            Program evaluacion = new Program();
            evaluacion.Cargar();
            evaluacion.MostrarExtremos();
            evaluacion.OrdenarMayorAMenor();
            evaluacion.ContarAprobados();

            Console.ReadKey();
    }
    }
}
