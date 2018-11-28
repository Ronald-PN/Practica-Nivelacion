using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EjercicioCodificacion_IV_IV
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("PROGRAMA QUE MUESTRA LA TABLA DEL 4");
            Console.WriteLine("=======================================");
            int resp;
            for (int i=1; i <= 12; i++)
            {
            resp = 4* i; 
           Console.WriteLine(4 + "*" + i + "=" + resp);
            }
            Console.ReadKey();
        }
}
}