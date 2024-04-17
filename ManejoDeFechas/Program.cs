using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ManejoDeFechas
{
    internal class Program
    {
        static void main(string[] args)    //........................................................se invalida este main por escribirse con "m"
        {
            DateTime dateTime = DateTime.Now;
            DateTime dt_ = new DateTime(1982,07,19,14,00,00);
            Console.WriteLine(dateTime);
            //DateTimeOffset
            Console.WriteLine(dt_);
            Console.WriteLine(dt_.DayOfWeek);
            //=====================================================================
            Console.WriteLine("=> Dates and Times:");
            // This constructor takes (year, month, day)
            DateTime dt = new DateTime(2010, 10, 17,12,30,30);
            Console.WriteLine("dt vale: " + dt);
            dt = dt.AddHours(2);
            Console.WriteLine("Sumando dos horas: "+dt);
            // What day of the month is this?
            Console.WriteLine("The day of {0} is {1}", dt.Date, dt.DayOfWeek);
            // Month is now December.
            dt = dt.AddMonths(2);
            Console.WriteLine("Sumando dos meses: "+dt);
            Console.WriteLine("Daylight savings: {0}", dt.IsDaylightSavingTime());
            // This constructor takes (hours, minutes, seconds)
            TimeSpan ts = new TimeSpan(4, 30, 0);
            Console.WriteLine(ts);
            // Subtract 15 minutes from the current TimeSpan and
            // print the result.
            Console.WriteLine(ts.Subtract(new TimeSpan(0, 15, 0)));
        }
    }
    
}
