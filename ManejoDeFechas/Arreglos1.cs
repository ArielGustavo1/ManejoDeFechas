using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*Desarrolle un programa que solicite al usuario la carga de un arreglo 
 * de 10 elementos. El programa tendrá un menú para dar las opciones de 
 * cargar arreglo mostrar el arreglo, calcular el promedio, mostrar el máximo 
 * y mostrar el mismo del arreglo de números.*/

namespace ManejoDeFechas
{
    internal class Arreglos1
    {
        static void main(string[] args) //........................................................se invalida este main por escribirse con "m"
        {

            string [] palabra = { "caca", "cacona","","caquina","nada" };
            arielfor(0, 3, 2, palabra);
            string texto = "ejemplo";
            char[] caracteres = texto.ToCharArray();

            for (int i = 0; i < caracteres.Length; i++)
            {
                if (caracteres[i] == 'e') // Cambiar 'e' por 'a'
                {
                    caracteres[i] = 'a';
                }
            }

            string nuevoTexto = new string(caracteres);
            Console.WriteLine(nuevoTexto);

        }


        public static void arielfor(int inicio, int fin, int incremento, string[] objeto )
        {
            for(int i = inicio; i <= fin; i += incremento)
            {
                Console.WriteLine(objeto[i]);
            }
        }
    }
}
