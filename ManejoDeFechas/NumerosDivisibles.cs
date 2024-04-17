using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ManejoDeFechas
{
    internal class NumerosDivisibles
    {
        static void main(string[] args) //........................................................se invalida este main por escribirse con "m"
        {
            
            int j, k, l=1;
            
            Console.WriteLine("Ingresar un num cualquiera: ");
            j=int.Parse(Console.ReadLine());
            Console.WriteLine("Ingresar un num cualquiera: ");
            k=int.Parse(Console.ReadLine());

            if (j < k)
            {
                for (int i =2; i<j-1;i++)
                {
                    if (j % i == 0)
                    {
                        if (k % i == 0) l = i;
                    }
                }
            }
            else
            {
                for (int i = 2; i < k - 1; i++)
                {
                    if (k % i == 0)
                    {
                        if (j % i == 0) l = i;
                    }
                }
            }

            imprimir("la fraccion queda: " + j / l+" y "+k/l+" lo que resulta en "+1.0*j/k);
            

            if (k % j == 0) imprimir("Además el segundo es divisible por el primero");
            else if (j%k == 0) imprimir("Además el primero es divisible por el segundo");
        }







        public static void imprimir(Object i)
        {
            Console.WriteLine(i);
        }
    }
}
