using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EjercicioCodificacion_3_1
{
    class Program
    {
        static void Main(string[] args)
        {
            double SB, SN=0, DD=0, TH, HT;
            Console.WriteLine("INGRESE LAS HORAS TRABAJADAS");
            HT=Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("=======================================");
            Console.WriteLine("INGRESE LA TARIFA POR HORA");
            TH = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("=======================================");
            SB = TH * HT;
            
            if (SB>=5000)
            {
                DD = SB * 0.10;
                SN = SB - DD;
                
            }
            else if (SB<5000)
            {
                DD = SB * 0.05;
                SN = SB - DD;
            }

            Console.WriteLine("SUELDO BRUTO: " + SB);
                Console.WriteLine("=======================================");
                Console.WriteLine("DESCUENTO: " + DD);
                Console.WriteLine("=======================================");
                Console.WriteLine("SUELDO NETO: " + SN);

            
          
            

            Console.ReadKey();
        }

    }
}
