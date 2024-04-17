using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*Dada la siguiente función lineal f(x) = mx + b. Crear una aplicación en c# 
 para que solicite los valores de m y b y que imprima los primeros 10 valores discretos de f(x).*/

namespace ManejoDeFechas
{
    internal class EstructurasRepetitivas2
    {
        static void main(string[] args) //........................................................se invalida con "m"
        {

            double m, b;
            



            Console.WriteLine("Escribir un num cualquiera para la pendiente m: ");
            m = int.Parse(Console.ReadLine());
            Console.WriteLine("Escribir un num cualquiera para la ordenada al origen b: ");
            b = int.Parse(Console.ReadLine());


            for (int i = 0; i <= 10; i++)
            {
                Console.WriteLine("Para x = " + i + " y = " + (m * i+b));
            }
            

        }







        

    }
}
