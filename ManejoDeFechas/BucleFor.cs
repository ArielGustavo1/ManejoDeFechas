using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*Utilice un bucle for para realizar un programa que pida 
 * un numero por pantalla y muestre todos los números impares 
 * desde el uno hasta el número ingresado separado por comas.*/


namespace ManejoDeFechas
{
    internal class BucleFor
    {
        static void main(string[] args) //........................................................se invalida este main por escribirse con "m"
        {
            Console.WriteLine("Ingresar un numero entero positivo");
            int i = int.Parse(Console.ReadLine());
            
            for(int j=1;j<=i; j++)
            {
                if (j % 2 != 0)
                    Console.WriteLine("numero impar: " + j);
            }


        }

    }
}
