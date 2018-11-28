using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EjercicioCodificacion_III_IV
{
    class Program
    {
        static void Main(string[] args)
        {
            int dia=0;
            Console.WriteLine("PRGRAMA QUE MUESTRA EL LOS DIAS DE LA SEMANA");
            Console.WriteLine("▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬");
            Console.WriteLine("INSERTE UN NUMERO");
           dia = Convert.ToInt32(Console.ReadLine());

            switch (dia)
            {
             case 1:
             Console.WriteLine("LUNES");
             break;
             case 2:
             Console.WriteLine("MARTES");
             break;
             case 3:
             Console.WriteLine("MIERCOLES");
             break;
             case 4:
             Console.WriteLine("JUEVES");
             break;
             case 5:
             Console.WriteLine("VIERNES");
             break;
             case 6:
             Console.WriteLine("SABADO");
             break;
             case 7:
             Console.WriteLine("DOMINGO");
             break;
             default:
             Console.WriteLine("EL NUMERO NO EXISTE");
             break;
           }
            Console.ReadKey();
      }
      }
      }