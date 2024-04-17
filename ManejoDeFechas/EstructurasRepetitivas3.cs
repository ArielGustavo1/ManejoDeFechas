using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


/*1. Dada la siguiente función lineal f(x) = mx + b. Crear una aplicación en c# para que solicite 
     los valores de m y b y que imprima los primeros 10 valores de f(x).
  2. Realice los cambios necesarios a la aplicación anterior para que puedan ingresarse nuevos 
     valores a las constantes m y b y que la aplicación retorne los primeros valores de f(x). Se espera 
     que la aplicación solicite los valores para una nueva función lineal hasta que se indique expresamente que se desea salir de la aplicación.*/
namespace ManejoDeFechas
{
    internal class EstructurasRepetitivas3
    {
        static void main(string[] args) //........................................................se invalida con "m"
        {
            double m, b;
            char c='s';

            do
            {
                Console.WriteLine("Escribir un num cualquiera para la pendiente m: ");
                m = double.Parse(Console.ReadLine());
                Console.WriteLine("Escribir un num cualquiera para la ordenada al origen b: ");
                b = double.Parse(Console.ReadLine());
                for (int i = 0; i <= 10; i++)
                {
                    Console.WriteLine("Para x = " + i + " y = " + (m * i + b));
                }
                Console.WriteLine("Para salir presionar \'s\'");
                c = Console.ReadKey().KeyChar;
                Console.WriteLine("");
            } while (c!='s');
            
            
        }
    }
}
