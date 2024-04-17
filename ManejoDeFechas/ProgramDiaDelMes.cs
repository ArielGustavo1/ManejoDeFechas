using System;

enum Dia { Lunes, Martes, Miercoles, Jueves, Viernes, Sabado, Domingo }
enum Mes { Enero = 31, Febrero = 28, Marzo = 31, Abril = 30, Mayo = 31, Junio = 30, Julio = 31, Agosto = 31, Septiembre = 30, Octubre = 31, Noviembre = 30, Diciembre = 31 };
class Program
{
    static void main(string[] args)//............................................................m
    {
        string anio, mes, dia;
        string[] diasDeSemana = Enum.GetNames(typeof(Dia));
        string[] meses = Enum.GetNames(typeof(Mes));
        int fecha, diferencia = 1, valorDias, ValorMes;
        int[] diasDelMes = (int[])Enum.GetValues(typeof(Mes));
        string[] mes_mes = null;
        //Console.WriteLine("Ingresar el año cualquiera: ");
        //anio = Console.ReadLine();
        Console.WriteLine("Ingresar un mes de cualquier año: ");
        mes = Console.ReadLine();
        Console.WriteLine("Ingresar cuál fue el primer día de ese mes: ");
        dia = Console.ReadLine();
        Console.WriteLine("Ingresar que fecha (en número) que quiere saber el día: ");
        fecha = int.Parse(Console.ReadLine());
        diferencia = fecha - diferencia;





        for (int i = 0; i < meses.Length; i++)
        {


            if (meses[i] == mes)
            {
                //Console.WriteLine(meses[i]);
                valorDias = diasDelMes[i];
                mes_mes = new string[valorDias];
                for (int j = 0; j < diasDeSemana.Length; j++)
                {
                    if (diasDeSemana[j] == dia)
                    {
                        //Console.WriteLine("jota vale: " + j);
                        //Console.WriteLine("dia de la semana: " + diasDeSemana[j]);
                        int m = j;
                        for (int k = 0; k < valorDias; k++)
                        {
                            int l = k + m;
                            mes_mes[k] = diasDeSemana[l];
                            //Console.WriteLine("ele vale: " + l);
                            if (l % 6 == 0 && l != 0)
                            {

                                m = -k - 1;
                                //Console.WriteLine("m vale: "+ m);
                            }

                        }

                    }
                }

            }

        }
        //foreach(string a in mes_mes)Console.WriteLine(a);

        Console.WriteLine("En esa fecha el día es: " + mes_mes[diferencia]);


        //matriz = (int)Mes.mes;
        //diasDelMes=new int[]
    }




}




