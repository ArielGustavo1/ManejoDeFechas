using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ManejoDeFechas
{
    internal class Ejercicio07
    {
        static void main(string[] args) //........................................................se invalida este main por escribirse con "m"
        {
            TimeSpan dif = new TimeSpan();
            int j;
            DateTime ahora= DateTime.Now;
            DateTime dt = new DateTime();
            Console.WriteLine("Ingresar un dia en formato (dd) cualquiera: ");
            dt=dt.AddDays(int.Parse(Console.ReadLine())-1);
            Console.WriteLine("Ingresar un mes en formato (mm) cualquiera: ");
            dt = dt.AddMonths(int.Parse(Console.ReadLine())-1);
            Console.WriteLine("Ingresar un año en formato (aaaa) cualquiera: ");
            dt = dt.AddYears(int.Parse(Console.ReadLine()) - 1);

            imprimir(dt);
            j = ahora.Year - dt.Year;
            dif = ahora - dt;
            imprimir("la edad es: " + (int)(dif.Days/365.0));

            
        }






        
        public static void imprimir(Object i)
        {
            Console.WriteLine(i);
        }
    }

    
}
