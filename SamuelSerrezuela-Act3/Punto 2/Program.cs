using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Punto2
{

    /*
     Se ingresan tres valores por teclado,
    si todos son iguales se imprime la suma del primero con el segundo
    y a este resultado se lo multiplica por el tercero.

*/


    class ProcesoNumeros
    {
        public int n1, n2, n3;

        public void Cargar()
        {
            Console.Write("Ingrese primer valor: ");
            n1 = int.Parse(Console.ReadLine());

            Console.Write("Ingrese segundo valor: ");
            n2 = int.Parse(Console.ReadLine());

            Console.Write("Ingrese tercer valor: ");
            n3 = int.Parse(Console.ReadLine());
        }

        public void Calcular()
        {

            if (n1 == n2 && n2 == n3)
            {
                int suma = (n1 + n2);
                Console.WriteLine("el resultado de la suma es : " +  suma); ;



                int resultado = (n1 + n2) * n3;
                Console.WriteLine("los tres son iguales.");
                Console.WriteLine("el resultado es: " + resultado);
            }
            else
            {
                Console.WriteLine("los numeros no son iguales");
            }
        }
    }

    class Program
    {
        static void Main()
        {
            ProcesoNumeros pn = new ProcesoNumeros();
            pn.Cargar();
            pn.Calcular();

            Console.ReadKey();
        }
    }
}


 