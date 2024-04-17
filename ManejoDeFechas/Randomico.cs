using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


/*Realice una aplicación utilizando do while para que se retornar un numero aleatorio, 
 * en caso de requerir más de manera expresa por consola. Muestre nuevos números aleatorios. 
 * Para ello utilice la clase random como se muestra a continuación. 
 * Random rnd = new Random(); int num = rnd.Next(1,30);*/

namespace ManejoDeFechas
{
    internal class Randomico
    {
        static void main(string[] args) //........................................................se invalida este main por escribirse con "m"
        {
            char opcion = 's';
            Console.WriteLine("Generación de número aleatorio");

            do
            {
                Random rnd = new Random();
                int num = rnd.Next(1, 31);

                Console.WriteLine("El numero aleatorio es: " + num);

                Console.WriteLine("Para obtener otro número aleatorio teclee \'s\'");
                opcion = Console.ReadKey().KeyChar;
                Console.WriteLine();

            } while (opcion == 's');



        }
    }
}
