using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
/*Realizar un programa que solicite el primer dia de cada uno de los doce meses. 
 * Con eso se le puede pedir al programa que devuelva qué día será en una fecha determinada y 
 * también sabrá responder qué fechas caen los fines de semana de un mes determinado*/
namespace DiaDelanio
{
    internal class Program
    {
        static void main(string[] args)//............................................................m
        {
            string dia_=null, mes=null, dia, fecha;
            string[] diasDelAnio = new string[365];
            string[] diasDeSemana = { "Lunes", "Martes", "Miercoles", "Jueves", "Viernes", "Sabado", "Domingo" };
            int[] diasDelMes = new int[365];
            short [] diasEnMes = {31,28,31,30,31,30,31,31,30,31,30,31 };                            //  no admite año bisiesto; febrero 29 dias
            int valorDia, valorMes, auxValorDia = 0;
            char aux;
            
            //Console.WriteLine("Ingresar el año cualquiera: ");
            //anio = Console.ReadLine();
            //Console.WriteLine("Ingresar un mes de cualquier año: ");
            //mes = Console.ReadLine();
            Console.WriteLine("Ingresar cuál fue el primer día del año: ");
            dia = Console.ReadLine();
            Console.WriteLine("Ingresar la fecha para saber qué día cae (dd/mm): ");
            fecha = Console.ReadLine();

            aux = fecha[0];
            dia_ = dia_+aux;
            aux= fecha[1];
            dia_=dia_+aux;
            aux= fecha[3];
            mes = mes + aux;
            aux = fecha[4];
            mes = mes + aux;
            valorDia = int.Parse(dia_);
            valorMes = int.Parse(mes);

            Console.WriteLine("valor dia y mes: " + valorDia + " " + valorMes);
            valorDia--;
            auxValorDia = valorDia;
            for (int i = 0;i<valorMes-1;i++)
            {
                valorDia = valorDia + diasEnMes[i];
            }
                
                
            //diferencia = fecha - diferencia;


            //Console.WriteLine(meses[i]);


            for (int j = 0; j < diasDeSemana.Length; j++)
            {
                 if (diasDeSemana[j] == dia)
                 {
                     //Console.WriteLine("jota vale: " + j);
                     //Console.WriteLine("dia de la semana: " + diasDeSemana[j]);
                     int m = j;
                    for (int k = 0; k < diasDelAnio.Length; k++)
                    {
                        int l = k + m;
                        diasDelAnio[k] = diasDeSemana[l];
                        //Console.WriteLine("ele vale: " + l);
                        if (l % 6 == 0 && l != 0)
                        {
                            m = -k - 1;
                            //Console.WriteLine("m vale: "+ m);
                        }
                    }
                 }
            }


            Console.WriteLine();
            Console.WriteLine("En esa fecha el día es: " + diasDelAnio[valorDia]);

            Console.WriteLine();
            Console.WriteLine("En ese mes los días de descanso (Sabado y Domingo) fueron: ");
            valorDia = valorDia - auxValorDia;
            int a = 1;
            for (int i = valorDia ; i < (valorDia+diasEnMes[valorMes]); i++)
            {
                
                if (diasDelAnio[i]=="Sabado" || diasDelAnio[i] == "Domingo")
                {
                    Console.WriteLine("Las fechas de los días de descanso son: "+a);
                }
                a++;
            }
            //foreach(string a in diasDelAnio)Console.WriteLine(a);

            //Console.WriteLine("día es: " + );


        }
    }
}
