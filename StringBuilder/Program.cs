using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StringBuilder
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("YO SOY UN PROGRAMADOR Y EXPERTO EN REDES RECONOCIDO");
            Console.WriteLine("#JAJAJA_FENOMENAL");
            /* string numeros = "";

             for (int i = 1; i<=100; i++)
             {
                 numeros += i + ",";

             }
             Console.WriteLine(numeros);*/
           

      var numeros = new StringBuilder();
            for(int i = 1; i <= 100; i++)
            {
                numeros.Append(i);
                numeros.Append(", ");
            }

           string cadenaNumeros = numeros.ToString();
            Console.WriteLine(cadenaNumeros);
        }
    }
}
