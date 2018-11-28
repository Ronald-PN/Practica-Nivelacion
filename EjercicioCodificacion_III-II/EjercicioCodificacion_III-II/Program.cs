using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EjercicioCodificacion_III_II
{
    class Program
    {
        static void Main(string[] args)
        {
            double nota1, nota2, nota3, nota4, Promedio=0;

            Console.WriteLine("PROGRAMA QUE CALCULA EL PROMEDIO DE 4 NOTAS");
            Console.WriteLine("▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬");
           
            Console.WriteLine("INSERTE LA PRIMERA NOTA");
            nota1 = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬");
            Console.WriteLine("INSERTE LA SEGUNDO NOTA");
            nota2 = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬");
            Console.WriteLine("INSERTE LA TERCERA NOTA");
            nota3 = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬");
            Console.WriteLine("INSERTE LA CUARTA NOTA");
            nota4 = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬");
            Promedio = (nota1 + nota2 + nota3 + nota4) / 4;
            Console.WriteLine("PROMEDIO: "+Promedio);
            if (Promedio>=0 && Promedio<65)
            {
                Console.WriteLine("REPROBADO");

            }else if (Promedio >=65 && Promedio <75)
            {
                Console.WriteLine("APROBADO");
            }

        else if (Promedio >=75 && Promedio<85)
            {
                Console.WriteLine("MUY BUENO");
            }
            else if (Promedio >=85 && Promedio < 90)
            {
                Console.WriteLine("SOBRESALIENTE");
            }
            else if (Promedio >=90 && Promedio <100)
            {
                Console.WriteLine("APROBADO");
            }
            
            Console.ReadKey();
        }

}
}
