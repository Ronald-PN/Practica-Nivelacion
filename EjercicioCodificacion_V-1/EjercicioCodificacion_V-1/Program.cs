using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EjercicioCodificacion_V_1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("PROGRAMA MUESTRA LA TABLA DE MULTIPLICAR DEL 4, CON WHILE");
            Console.WriteLine("____________________________________________________________");
            int resp, a=1;
            while (a<=12)
            {
               resp = 4 * a;
               
                Console.WriteLine(resp+ "*"+ a+ "="+ resp);
                a++;
            }
            Console.ReadKey();
        }
    }
}