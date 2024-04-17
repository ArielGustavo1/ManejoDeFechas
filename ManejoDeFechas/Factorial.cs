using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*Dado un número entero positivo ingresado por consola mostrar su factorial. 
 * La factorial de un número es la multiplicación de todos los números enteros 
 * positivos que hay entre 1 y ese número, el factorial de 0 es 1.*/

namespace ManejoDeFechas
{
    internal class Factorial
    {
        static void main(string[] args) //........................................................se invalida este main por escribirse con "m"
        {
           int i = 0;



            do
            {
                Console.WriteLine("Ingresar un numero entero positivo para calcular factorial");
                i = int.Parse(Console.ReadLine());
                if (i < 0)
                {
                    Console.WriteLine("Numero inválido, intentar nuevamente");
                    i = 1;
                }
                else if (i == 0 || i == 1)
                {
                    i = 1;
                    Console.WriteLine("El factorial es: "+i);
                    i = 0;

                }
                else
                {
                    for (int j = i - 1; j > 0; j--)
                    {
                        i *= j;

                    }
                    Console.WriteLine($"El factorial es: {i}");

                }


            } while (i > 0);


        }
    }
}
