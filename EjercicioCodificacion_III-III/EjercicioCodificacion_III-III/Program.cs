using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EjercicioCodificacion_III_III
{
    class Program
    {
        static void Main(string[] args)
        {
            int edad; ;

            Console.WriteLine("PROGRAMA QUE CALCULA LA EDAD DE UNA PERSONA");
            Console.WriteLine("▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬");
            Console.WriteLine("POR FAVOR INTRODUZCA LA EDAD");
            edad = Convert.ToInt32(Console.ReadLine());
         

            if (edad > 0 && edad <=1)
            {
                Console.WriteLine("BABY");

            }
            else if (edad >= 2 && edad <=12)
            {
                Console.WriteLine("NIÑO");
            }

            else if (edad >=13 && edad<= 17)
            {
                Console.WriteLine("ADOLESCENTE");
            }
                  else if (edad >=18 && edad<=30)
            {
                Console.WriteLine("JOVEN");
            }
            else if (edad >=31 && edad <=64)
            {
                Console.WriteLine("ADULTO");
            }
            else if (edad >=65 && edad <=120)
            {
                Console.WriteLine("ANCIANO");
            }
            else if (edad >=120)
            {
                Console.WriteLine("ERROR");
                
            }

            Console.ReadKey();
        }
    }
}
