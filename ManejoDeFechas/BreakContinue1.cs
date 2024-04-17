using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*Realice un programa que retorne cien números aleatorios cuales 
 * quiera excepto que este número generado sea múltiplo de cinco en cuyo 
 * caso deberá cortar la ejecución del programa de inmediato.*/

namespace ManejoDeFechas
{
    internal class BreakContinue1
    {
        static void main(string[] args) //........................................................se invalida este main por escribirse con "m"
        {
            Random rnd = new Random();

            
            for (int l = 0; l < 100; l++)
            {
                int a = rnd.Next(0, 100);

                Console.WriteLine("El numero aleatorio es: "+a);
                if (a % 5 == 0) { Console.WriteLine("El número es múltiplo de cinco, termina el proceso"); break; }
                
            }
            

        }
    }
}
