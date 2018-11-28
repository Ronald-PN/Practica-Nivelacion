using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalcularPromedio4Notas
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("ESTE PROGRAMA CALCULARA EL PROMEIDO DE 4 NOTAS");
            Console.WriteLine("▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬");
            //DECLARO LAS VARIABLES NOTAS
            double NotaEnero, NotaFebrero, NotaMarzo, NotaAbril, Promedio;
            Console.WriteLine("POR FAVOR INGRESE LA NOTA DE ENERO");
            NotaEnero = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("POR FAVOR INGRESE LA NOTA DE FEBRERO");
            NotaFebrero = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("POR FAVOR INGRESE LA NOTA DE MARZO");
            NotaMarzo = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("POR FAVOR INGRESE LA NOTA DE ABRIL");
            NotaAbril = Convert.ToDouble(Console.ReadLine());
            Promedio = (NotaEnero + NotaFebrero + NotaMarzo + NotaAbril) / 4;
            Console.WriteLine("EL PROMEDIO DEL ESTUDIANTE ES:" + "" +Promedio);
            Console.ReadLine();
        }
    }
}
