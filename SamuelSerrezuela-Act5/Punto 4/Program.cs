using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Punto_4
/*Se cuenta con la siguiente información:
● Las edades de 20 estudiantes del turno mañana.
● Las edades de 30 estudiantes del turno tarde.
● Las edades de 15 estudiantes del turno noche.
Las edades de cada estudiante deben ingresarse por teclado.
a) Obtener el promedio de las edades de cada turno (tres promedios)
b) Imprimir dichos promedios (promedio de cada turno)
c) Mostrar por pantalla un mensaje que indique cuál de los tres turnos tiene un
promedio de edades menor.*/
{
    internal class Program
    {
        static void Main(string[] args)
        {
            float sumaMañana = 0, sumaTarde = 0, sumaNoche = 0;
            float promMañana, promTarde, promNoche;

            
            Console.WriteLine("█████ Turno Mañana █████");
            for (int i = 1; i <= 20; i++)
            {
                Console.Write("Edad alumno : ");
                Console.WriteLine(i);
                
                sumaMañana += int.Parse(Console.ReadLine());
            }

            
            Console.WriteLine("█████ Turno Tarde █████");
            for (int i = 1; i <= 30; i++)
            {
                Console.Write("Edad alumno: ");
                Console.WriteLine(i);
                sumaTarde += int.Parse(Console.ReadLine());
            }

            
            Console.WriteLine("█████ Turno Noche █████");
            for (int i = 1; i <= 15; i++)
            {
                Console.Write("Edad alumno : ");
                Console.WriteLine(i);
                sumaNoche += int.Parse(Console.ReadLine());
            }

           
            promMañana = sumaMañana / 20;
            promTarde = sumaTarde / 30;
            promNoche = sumaNoche / 15;

            
            Console.WriteLine("█████ Promedios por Turno █████");
            Console.WriteLine("Promedio Mañana: " + promMañana);
            Console.WriteLine("Promedio Tarde: " + promTarde);
            Console.WriteLine("Promedio Noche: " + promNoche);

          
            Console.Write("El turno con el menor promedio es: ");
            if (promMañana < promTarde && promMañana < promNoche)
            {
                Console.WriteLine("Mañana");
            }
            else if (promTarde < promNoche)
            {
                Console.WriteLine("Tarde");
            }
            else
            {
                Console.WriteLine("Noche");

            }
            Console.ReadKey();
        }
    }
}

