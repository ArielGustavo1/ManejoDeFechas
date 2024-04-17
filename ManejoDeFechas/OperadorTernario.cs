using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*
5. Dado tres números ingresados por consola a, b,y c. Luego imprima la salida la combinación 
ingresada es correcta si coinciden con el siguiente criterio de búsqueda. a <=c , b>=a y c*a ==10
*/

namespace ManejoDeFechas
{
    

    internal class OperadorTernario
    {
        static void main(string[] args) //........................................................se invalida este main por escribirse con "m"
        {
            Console.WriteLine("ingresar el primer número de tres");
            int a = int.Parse(Console.ReadLine());
            Console.WriteLine("ingresar el segundo número de tres");
            int b = int.Parse(Console.ReadLine());
            Console.WriteLine("ingresar el tercer número de tres");
            int c = int.Parse(Console.ReadLine());

            dynamic salida = (a <= c) ? "Secuencia correcta" : "Secuencia incorrecta";
            Console.WriteLine(salida);
            
            salida = (a <= b) ? "Secuencia correcta" : "Secuencia incorrecta";
            Console.WriteLine(salida);
            
            salida = (a * c==10) ? "Secuencia correcta" : "Secuencia incorrecta";
            Console.WriteLine(salida);

            salida = (a * c == 10 && a<=b && a<=c) ? "Secuencia triple correcta" : "Secuencia triple incorrecta";
            Console.WriteLine(salida);
        }
    }
}
