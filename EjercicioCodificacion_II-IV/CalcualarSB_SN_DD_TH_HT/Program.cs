using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalcualarSB_SN_DD_TH_HT
{
    class Program
    {
        static void Main(string[] args)
        {
           Console.WriteLine("ESTE PROGRAMA CALCULA EL SUELDO BRUTO, SUELD NETO Y DESCUENTO DE UN EMPLEADO, APLICANDOLE LAS HORAS TRABAJADAS Y LA TARIFA POR HORA");

            double TH, SB, SN, DD;
            int HT;

            Console.WriteLine("==================================================");
            Console.WriteLine("POR FAVOR INGRESE LAS HORAS TRABAJADAS");
            HT = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("==================================================");
            Console.WriteLine("POR FAVOR INGRESE LA TARIFA POR HORA");
            TH = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("==================================================");

            SB = TH * HT;
            DD = SB * 0.10;
            SN = SB - DD;

            Console.WriteLine("SUELDO BRUTO:" + SB);
            Console.WriteLine("==================================================");
            Console.WriteLine("DESCUENTO:" + DD);
            Console.WriteLine("==================================================");
            Console.WriteLine("SUELDO NETO:" + SN);
            Console.ReadKey();
        }
    }
}
