using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*Utilice do-while para entregar la sumatoria de uno a 100 de todos los múltiplos de dos.*/

namespace ManejoDeFechas
{
    internal class SumaCero_Cien
    {

        static void main(string[] args) //........................................................se invalida este main por escribirse con "m"
        {
            short i=0,a=0;
            
            Console.WriteLine("Sumatoria de 0-100 de multiplos de dos");

            do
            {
                //Console.WriteLine("a es: " + a);
                if (i % 2 == 0) a += i;
                i++;

            } while (i<100);

            Console.WriteLine("la sumatoria es: "+a);


        }



    }
}
