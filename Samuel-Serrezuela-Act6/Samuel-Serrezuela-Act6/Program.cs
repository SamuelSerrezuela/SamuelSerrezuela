using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*Desarrollar una clase que represente un punto en el plano y tenga los
siguientes métodos: cargar los valores de x e y, imprimir en que cuadrante se
encuentra dicho punto (concepto matemático, primer cuadrante si x e y son
positivas, si x>;0 e y<;0 segundo cuadrante, etc.)
*/


namespace Punto1
{
    class Punto
    {

        public float x;
        public float y;


        public void cargar()
        {
            Console.Write("ingresa X : ");
            x = float.Parse(Console.ReadLine());

            Console.Write("ingresa Y : ");
            y = float.Parse(Console.ReadLine());
        }


        public void imprimirCuadrante()
        {
            if (x > 0 && y > 0)
            {
                Console.WriteLine("Está en el 1º Cuadrante.");
            }
            else if (x < 0 && y > 0)
            {
                Console.WriteLine("Está en el 2º Cuadrante.");
            }
            else if (x < 0 && y < 0)
            {
                Console.WriteLine("Está en el 3º Cuadrante.");
            }
            else
            {
                Console.WriteLine("El punto está sobre un eje o en el centro.");
            }
        }




        static void Main(string[] args)
        {
            Punto p = new Punto();
            p.cargar();
            p.imprimirCuadrante();
            Console.ReadKey();
        }
    }
}












