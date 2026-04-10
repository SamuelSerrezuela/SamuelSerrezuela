using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*Confeccionar una clase que represente un empleado. Definir como atributos su
nombre y su sueldo. Confeccionar los métodos para la carga, otro para imprimir
sus datos y por último uno que imprima un mensaje si debe pagar impuestos
(si el sueldo supera a 3000).*/

namespace Punto_3
{
    class empleado
    {
        public string nombre;
        public float sueldo;



        public void detalles()
        {
            Console.Write("igrese el nombre de la persona:  ");
            nombre = Console.ReadLine();

            Console.Write("ingrese el sueldo de la persona ");
            sueldo = float.Parse(Console.ReadLine());
        }

        public void metodos()
        {

            Console.WriteLine("---datos el empleado---");
            Console.WriteLine("Nombre del usuario : " + nombre);
            Console.WriteLine("Sueldo correspondiente de la persona : " + sueldo);
        }

        public void impuestos()
        {

            if (sueldo > 3000)
            {
                Console.WriteLine("el usuario debe pagar inpuestos ");
            }


            else
            {
                Console.WriteLine("no debe pagar impuestos");
            }
        }








            static void Main(string[] args)
            {
                empleado emp = new empleado();
                emp.detalles();
                emp.metodos();
                emp.impuestos();
                Console.ReadKey();  


            }
    }
}
