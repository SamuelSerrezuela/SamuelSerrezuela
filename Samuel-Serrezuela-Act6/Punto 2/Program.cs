using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*Desarrollar una clase que represente un Cuadrado y tenga los siguientes
métodos: cargar el valor de su lado, imprimir su perímetro y su superficie.)
*/



class cuadrado 
{

    private int lado;
   


    public void cargar()
    {
        Console.Write("ingresa el valor del lado del cuadrado : ");
        lado = int.Parse(Console.ReadLine());

        


    }


    public void imprimirperimetro()
    {
        int perimetro = lado + lado + lado + lado;
        Console.WriteLine("El perímetro sumando sus 4 lados es: " + perimetro);

    }

    public void sacarSuperficie()
    {
        int superficiez = lado * lado;
        Console.WriteLine("El valor de la superficie es: " +  superficiez);
        /// cejaz negraz
    }




    static void Main(string[] args)
    {
        cuadrado cd = new cuadrado();
        cd.cargar();
        cd.imprimirperimetro();
        cd.sacarSuperficie();
        Console.ReadKey();
        
    }
}











