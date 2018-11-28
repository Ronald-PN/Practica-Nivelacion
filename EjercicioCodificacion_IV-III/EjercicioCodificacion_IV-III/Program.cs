using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EjercicioCodificacion_IV_III
{
    class Program
    {
        static void Main(string[] args)
        {
            int cubo;
            Console.WriteLine("PROGRAMA QUE MUESTRA LOS NUMEROS DEL 3 AL 20 CON SU CUBO AL LADO");
            Console.WriteLine("▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬");
            for (int i = 3; i <= 20; i++)
            {
                Console.WriteLine(i);
                cubo = i * i * i;
               
                Console.WriteLine(i+ "" +cubo);
             
            }
            Console.ReadKey();
        }
    }
}
