using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EjercicioCodificacion__V_II
{
    class Program
    {
        static void Main(string[] args)
        {
            int opcion=0;
            do
            {
                Console.WriteLine("───────────────MENU PARA ELEGIR───────────────");
                Console.WriteLine("[1]  CALCULAR PROMEDIO");
                Console.WriteLine("[2] TABLA DE MULTIPLICAR");
                Console.WriteLine("[3] SALIR DEL SISTEMA");
                Console.WriteLine("ELIJA LA OPCION");
                opcion = Convert.ToInt32(Console.ReadLine());
                Console.Clear();
                if (opcion == 1)
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
                    Console.WriteLine("EL PROMEDIO DEL ESTUDIANTE ES:" + "" + Promedio);

                }
                else if (opcion == 2)
                {
                    Console.WriteLine("ESTE PROGRAMA MUESTRA LA TABLA DE MULTIPLICAR");
                    Console.WriteLine("▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬");
                    int resp = 0;
                    for (int i = 1; i <= 12; i++)
                    {
                        Console.WriteLine("");
                        Console.WriteLine("LA TABLA DEL: " + i);
                        for (int t = 1; t <= 12; t++)
                        {
                            resp = t * i;
                            Console.WriteLine(t + "*" + i + "=" + resp);
                        }
                    }
                }

                else if (opcion == 3)
                {
                    Console.WriteLine("HAS ELEGIDO LA OPCION SALIR, PULSE CUALQUIER TECLA PARA SALIR");
                }
                Console.ReadKey();

            } while (opcion ==1 && opcion==2 && opcion==3);
}
    }
}