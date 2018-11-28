using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MostrarInformacionPersona
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.BackgroundColor = ConsoleColor.Blue;
            Console.BackgroundColor = ConsoleColor.Black;
            Console.WriteLine("▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬");
            //QUISE DAR VALOR A MIS VARIABLES PARA LUEGO UTILIZARLA UTILIZANDO LA CONCATENACION
            string Nombre = "RONALD", Apellido = "PEÑA NUÑEZ", Apodo = "RONALD", Pais = "REP. DOM",
            Ciudad = "BARAHONA", Direccion = "DR. FERIS OLIVERO #00, EL PEÑON", LugarTrabajo = "LICEO EL PEÑON";
            double Sueldo=15000;
            ulong Telefono=8298321439, Movil=8094289055;

            Console.WriteLine("▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬");
            Console.WriteLine("INFORMACION DE UNA PERSONA");
            Console.WriteLine("▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬");
            Console.WriteLine("NOMBRE:"+Nombre);
            Console.WriteLine("APELLIDO:" + Apellido);
            Console.WriteLine("APODO:" + Apodo);
            Console.WriteLine("PAIS:" + Pais);
            Console.WriteLine("CIUDAD:" + Ciudad);
            Console.WriteLine("DIRECCION:" + Direccion);
            Console.WriteLine("LUGAR DE TRABAJO:" + LugarTrabajo);
            Console.WriteLine("SUELDO:" + Sueldo);
            Console.WriteLine("TELEFONO:" + Telefono);
            Console.WriteLine("MOVIL:" + Movil);
            Console.WriteLine("▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬▬");


            Console.ReadKey();
        }
    }
}
