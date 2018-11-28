using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EjercicioCodificacion_IV_V
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("PROGRAMA QUE MUESTRA LA TABLA DEL 1 AL 12");
            Console.WriteLine("=======================================");
            int  resp=0;
            for (int i = 1; i <= 12; i++)
            {
                Console.WriteLine("");
                Console.WriteLine("LA TABLA DEL: "+i);
                
                for (int t=1; t<=12; t++)
                {
                    
                    resp = t * i;
                Console.WriteLine(t + "*" + i + "=" + resp);
            }
            }
            Console.ReadKey();
       
    }
    }
}