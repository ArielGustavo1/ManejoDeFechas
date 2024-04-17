using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*6. Dado tres números ingresados por consola a, b y c 
 * determine si los números coinciden con el siguiente criterio
a <=c , b>=a y c*a ==10 o b-c==4 y a+b =8*/


namespace ManejoDeFechas
{
    internal class OperadorTernario2
    {
        static void main(string[] args) //........................................................se invalida este main por escribirse con "m"
        {
            Console.WriteLine("ingresar el primer número de tres");
            int a = int.Parse(Console.ReadLine());
            Console.WriteLine("ingresar el segundo número de tres");
            int b = int.Parse(Console.ReadLine());
            Console.WriteLine("ingresar el tercer número de tres");
            int c = int.Parse(Console.ReadLine());

            dynamic salida = (a * c == 10 && a <= b && a <= c || b-c ==4 && a+b==8) ? "Secuencia triple correcta" : "Secuencia triple incorrecta";
            Console.WriteLine(salida);
        }
    }
}
