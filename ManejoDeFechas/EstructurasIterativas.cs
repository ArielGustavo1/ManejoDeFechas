using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ManejoDeFechas
{
    internal class EstructurasIterativas
    {
        static void main(string[] args) //........................................................se invalida este main por escribirse con "m"
        {

            int j, k;
            
            

            print("Escribir un num cualquiera para ver su tabla del 1 al 10: ");
            j = int.Parse(Console.ReadLine());

            for (int i= 0;i <=10;i++)
            {
                Console.WriteLine(i*j);
            }

        }







        public static void print(Object i)
        {
            Console.WriteLine(i);
        }

    }
}
