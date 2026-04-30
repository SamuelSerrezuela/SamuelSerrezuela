using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*Cargar un vector de n elementos. imprimir el menor y un mensaje si se repite dentro
del vector.*/



namespace SamuelSerrezuela_Act8
{
    class Vectors
    {

        int[] elementos;
        int menor = 0;
        int mayor = 0;

        public void Cargar()
        {
            Console.WriteLine("ingrese el numero de elementos del vector");
            int n = int.Parse(Console.ReadLine());
            elementos = new int[n];
            for (int i = 0; i < n; i++)
            {
                Console.WriteLine("ingrese el elemento " + (i + 1));
                elementos[i] = int.Parse(Console.ReadLine());
            }
        }

        public void minimo()
        {
            
            menor = elementos[0];

            
            for (int i = 1; i < elementos.Length; i++)
            {
                if (elementos[i] < menor)
                {
                    menor = elementos[i];
                }
            }

            Console.WriteLine($"\nel menor elemento del vector es: {menor}");

            
            int contadorRepeticiones = 0;
            for (int i = 0; i < elementos.Length; i++)
            {
                if (elementos[i] == menor)
                {
                    contadorRepeticiones++;
                }
            }

            
            if (contadorRepeticiones > 1)
            {
                Console.WriteLine("el número menor se repite dentro del vector.");
            }
            else
            {
                Console.WriteLine("el número menor no se repite.");
            }
        }



        static void Main(string[] args)
        {
            Vectors pml = new Vectors();
            pml.Cargar();
            pml.minimo();
            Console.ReadKey();
        }
    }
}
