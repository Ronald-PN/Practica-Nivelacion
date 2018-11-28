using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace programaSumaDosValores
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.BackgroundColor = ConsoleColor.Blue;
            Console.BackgroundColor = ConsoleColor.Black;
            Console.Clear();

            Console.WriteLine("▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬");
            // declaro las variables
            double v1, v2, Respuesta=0;

            Console.WriteLine("▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬");
            Console.WriteLine("FAVOR INGRESAR EL VALOR 1");
            v1 = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("FAVOR INGRESAR EL VALOR 2");
            v2 = Convert.ToDouble(Console.ReadLine());
            Respuesta = v1 + v2;
            Console.WriteLine("LA SUMA DE LOS DOS NUMEROS ES IGUAL A:" + " " +Respuesta);
            Console.ReadKey();
        }
    }
}
