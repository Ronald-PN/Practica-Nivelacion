using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EjercicioCodificacion_VI_I
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("PROGRAMA VECTOR QUE CARGA 5 CODIGOS VALIDOS");
            Console.WriteLine("______________________________________________");
            int[] x = new int[5];

            x[0] = 10;
            x[1] = 20;
            x[2] = 30;
            x[3] = 40;
            x[4] = 50;
            for (int i = 0; i <= 4; i++)
            {
                Console.WriteLine(x[i]);
            }
            Console.ReadKey();
        }
    }
    }
