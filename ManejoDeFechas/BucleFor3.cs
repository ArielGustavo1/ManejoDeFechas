using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*Utilice un bucle for para determinar la cantidad de cuotas 
 * y el monto de las mismas si se desea comprar un electrodoméstico 
 * en cómodas cuotas. El programa le solicitara el precio del electrodoméstico 
 * y el porcentaje de interés y la cantidad de cuotas en las que pagara.*/

namespace ManejoDeFechas
{
    internal class BucleFor3
    {
        static void main(string[] args) //........................................................se invalida este main por escribirse con "m"
        {
            Console.WriteLine("Ingresar el precio del producto");
            double precio = double.Parse(Console.ReadLine());
            Console.WriteLine("Ingresar la cantidad de cuotas en la que compra el producto");
            int cantCuotas = int.Parse(Console.ReadLine());
            Console.WriteLine("Ingresar el interés de la compra del producto en porcentaje");
            double interes= double.Parse(Console.ReadLine());
            double cuota = 0;
            Console.WriteLine("Estos cálculos corresponden al tipo de interés llamado: interés directo");

            if (interes == 0) interes = 1;
            else interes = 1 + (interes / 100.0);

            for ( int l=0; l <= cantCuotas; l++)
            {
                    
                Console.WriteLine($"El monto a pagar de la cuota {l} es: {cuota:f2}");
                
                cuota = precio * interes /cantCuotas;
            }
            Console.WriteLine("El monto total a pagar es: " + (precio * interes));

        }

    }
}
