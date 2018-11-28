using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalcularCuotaPrestamo
{
    class Program
    {
        static void Main(string[] args)
        {
            double Monto, Interes, c;
            int Tiempo;
            Console.WriteLine("POR FAVOR INGRESE EL MONTO A PRESTAR");
            Monto = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("=====================================");
            Console.WriteLine("INSERTE EL TIEMPO");
            Tiempo = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("=====================================");
            Console.WriteLine("INSERTE EL INTERES");
            Interes = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("=====================================");
            c =((Monto*Interes)/Tiempo)+(Monto / Tiempo);
            Console.WriteLine("LA CUOTA DEL PRESTAMO ES DE : " + c);
            Console.ReadKey();
        }
    }
}
