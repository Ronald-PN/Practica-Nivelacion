using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NombreProductoPrecioTotalPagar
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.BackgroundColor = ConsoleColor.Blue;
            Console.ForegroundColor = ConsoleColor.White;
            Console.Clear();
            Console.WriteLine("ESTE PROGRAMA PEDIRA EL NOMBRE DEL PRODUCTO, PRECIO Y LA CANTIDAD ");
            Console.WriteLine("___________________________________________________________________");
            string Producto;
            int Cantidad;
            double PrecioSinItebis, MontoItebis, Subtotal, TotalPagar;
            Console.WriteLine("PRODUCTO:");
            
            Producto = Convert.ToString(Console.ReadLine());
            Console.WriteLine("___________________________________________________________________");
            Console.WriteLine("CANTIDAD:");
          
            Cantidad = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("PRECIO SIN ITEBIS:");
           
            PrecioSinItebis = Convert.ToDouble(Console.ReadLine());
            
            Subtotal = Cantidad * PrecioSinItebis ;
            MontoItebis =Subtotal  *0.18;
            TotalPagar = Subtotal+MontoItebis;
            Console.WriteLine("___________________________________________________________________");
            Console.WriteLine("SUBTOTAL:  "+ Subtotal);
            Console.WriteLine("___________________________________________________________________");
            Console.WriteLine("MontoItebis:  "  + MontoItebis);
            Console.WriteLine("___________________________________________________________________");
            Console.WriteLine("TOTAL A PAGAR:  " + TotalPagar);

            Console.ReadKey();


        }
    }
}
