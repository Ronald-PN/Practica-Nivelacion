using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EjercicioCodificacion_VI_II
{
    class Program
    {
        static void Main(string[] args)
        {
            int[,] A = new int[2, 2];
            A[0, 0] = 70;
            A[0, 1] = 60;
            A[1, 0] = 80;
            A[1, 1] = 70;

            int[,] B = new int[2, 2];
            B[0, 0] = 68;
            B[0, 1] = 90;
            B[1, 0] = 80;
            B[1, 1] = 70;

            int[,] C = new int[2, 2];

            for (int z=0; z<2; z++)
            {
           for (int c = 0; c <2; c++)
           {
          Console.WriteLine(z + " " + c);
           C[z, c] = A[z, c] + B[z, c];
          }
          }
            for (int z = 0; z < 2; z++)
          {
          Console.WriteLine(" ");
          for (int c = 0; c < 2; c++)
           {
             Console.WriteLine(C[z, c]+"");
                  

                }
            }
            Console.ReadKey();
    }

}
}