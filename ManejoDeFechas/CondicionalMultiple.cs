using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ManejoDeFechas
{
    internal class CondicionalMultiple
    {
        static void main(string[] args) //........................................................se invalida este main por escribirse con "m"
        {
            int a = 0, suma = 0;
            double promedio = 0;
            Random rnd = new Random();


            for (int l = 0; l < 3; l++)
            {
                a = rnd.Next(1, 10);
                Console.Write("\nEl numero aleatorio es: " + a);
                //Console.Write("");
                suma += a;
            }
            promedio = suma / 3.0;
            Console.WriteLine("\nEl promedio es: " + promedio);
            if ((int) promedio<=3)
                Console.WriteLine("Insuficiente");
            else if ((int)promedio <= 5)
                Console.WriteLine("Aprobado");
            else if ((int)promedio <= 7)
                Console.WriteLine("Bueno");
            else if ((int)promedio <= 9)
                Console.WriteLine("Distinguido");
            else 
                Console.WriteLine("Sobresaliente");
        }
    }
}
