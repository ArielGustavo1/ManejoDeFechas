using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*Realice un programa que retorne la suma de cien números aleatorios cuales 
 * quiera excepto que este número generado sea múltiplo de cinco en cuyo caso lo 
 * ignorará y continuara con las próximas iteraciones.*/

namespace ManejoDeFechas
{
    internal class BreakContinue2
    {
        static void main(string[] args) //........................................................se invalida este main por escribirse con "m"
        {
            int a = 0, suma = 0;
            Random rnd = new Random();


            for (int l = 0; l < 10; l++)
            {
                a = rnd.Next(1,10);
                Console.Write("\nEl numero aleatorio es: " + a);
                if (a % 5 == 0) { Console.Write(" El número es múltiplo de cinco"); continue; }
                suma += a;
            }

            Console.WriteLine("\nLa suma es: " + suma);
        }
    }
}
