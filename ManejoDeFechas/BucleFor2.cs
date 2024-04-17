using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*Utilice un bucle for para realizar un programa que 
 * muestre en orden inverso todos los números múltiplos 
 * de 4 desde un numero ingresado por pantalla.*/

namespace ManejoDeFechas
{
    internal class BucleFor2
    {

        static void main(string[] args) //........................................................se invalida este main por escribirse con "m"
        {
            Console.WriteLine("Ingresar un numero entero positivo");
            int i = int.Parse(Console.ReadLine());

            for (int j = i; j>0; j--)
            {
                if (j % 4 == 0)
                    Console.WriteLine("numero impar: " + j);
            }


        }
    }
}
