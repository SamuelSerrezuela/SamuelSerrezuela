using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*Implementar la clase operaciones. Se deben cargar dos valores enteros,
calcular su suma, resta, multiplicación y división, cada una en un método,
imprimir dichos resultados.
 */

namespace punto_4
{
    class matematica
    {
        int x, y;

        public void cargar ()
        {
            Console.Write("ingresa el 1er numero : ");
            x = int.Parse(Console.ReadLine());

            Console.Write("ingresa el 2do numero : ");
            y = int.Parse(Console.ReadLine());

        }

        public void suma()
        {
            int suma = x + y;
            Console.WriteLine("la suma de los valores es: " + suma);
        }

        public void resta()
        {
            int resta = x - y;
            Console.WriteLine("la resta de los valoores es : " + resta);
        }

        public void multiplicacion()
        {

            int multiplicacion = x * y;
            Console.WriteLine("la multiplicacion entre los valores es : " + multiplicacion);
        }

        public void division()
        {
            int division = x / y;
            Console.WriteLine("la division entre los valores es : " + division);
        }

            








        static void Main(string[] args)
        {
            matematica mt= new matematica();
            mt.cargar();
            mt.suma();
            mt.resta();
            mt.multiplicacion();
            mt.division();
            Console.ReadKey();
        }
    }
}
