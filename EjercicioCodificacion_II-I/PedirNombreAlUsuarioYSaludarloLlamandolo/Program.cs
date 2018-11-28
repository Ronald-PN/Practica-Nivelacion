using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PedirNombreAlUsuarioYSaludarloLlamandolo
{
    class Program
    {
        static void Main(string[] args)
        {
            string Nombre ;
            Console.WriteLine("SEÑOR USUARIO, POR FAVOR ESCRIBA SU NOMBRE");
            Nombre = Convert.ToString(Console.ReadLine());
            Console.WriteLine("HOLA" + " " +Nombre + ", " +"BIENVENIDO A C#");
            Console.ReadKey();
        }
    }
}
