using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Punto_3

/*En un banco se procesan datos de las cuentas corrientes de sus clientes. De cada
cuenta corriente se conoce: número de cuenta y saldo actual. El ingreso de datos debe
finalizar al ingresar un valor negativo en el número de cuenta.
Se pide confeccionar un programa que lea los datos de las cuentas corrientes e
informe:
a) De cada cuenta: número de cuenta y estado de la cuenta según su saldo, sabiendo
que:
Estado de la cuenta:
○ “Acreedor” si el saldo es >;0.
○ “Deudor” si el saldo es <;0.
○ “Nulo” si el saldo es =0.
b) La suma total de los saldos acreedores.*/
{
    internal class Program
    {
        static void Main(string[] args)
        { 

                int nroCuenta;
                double saldo, sumaAcreedores = 0;

                while (true)
                {
                    Console.Write("Ingrese número de cuenta (negativo para finalizar): ");
                    nroCuenta = int.Parse(Console.ReadLine());

                    if (nroCuenta < 0) break;

                    Console.Write("Ingrese saldo actual: ");
                    saldo = double.Parse(Console.ReadLine());
                   
                    string estado;
                    if (saldo > 0)
                    {
                        estado = "Acreditado";
                        sumaAcreedores += saldo;    
                    }
                    else if (saldo < 0)
                    {
                        estado = "Deudor";
                    }
                    else
                    {
                        estado = "Nulo";
                    }

                Console.Write("cuenta : ");
                Console.WriteLine(nroCuenta);
                Console.Write("estado: ");
                Console.WriteLine(estado);
                
                    Console.WriteLine("▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓▓");
                }

            Console.Write("Suma total de saldos acreedores: ");
            Console.WriteLine(sumaAcreedores);
            

            Console.ReadKey();
        }
        }

    }











               