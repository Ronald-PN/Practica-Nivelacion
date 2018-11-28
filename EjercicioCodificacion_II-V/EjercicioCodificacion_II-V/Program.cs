using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EjercicioCodificacion_II_V
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("ESTE PROGRAMA CONVIERTE LA MEDIDA DE CENTIMETROS A PULGADASS <(-_-)>");
            Console.WriteLine("--------------------------------------------------------------------");
            double Centimetros, Pulgadas = 0;

            Console.WriteLine("CUANTOS CENTRIMETROS DESEA CONVERTIR?");
            Console.WriteLine("====================================================================");
            Centimetros = Convert.ToDouble(Console.ReadLine());

            Pulgadas = Centimetros / 2.54;
            Console.WriteLine("PULGADAS:" + " " + Pulgadas);

            Console.ReadKey();
        }
    }
}
