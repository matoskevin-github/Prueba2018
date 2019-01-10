using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo_CSharp_04
{
    class Program
    {
        static void Main(string[] args)
        {
            string strNombre;
            int edad;

            Console.Write("Ingrese su nombre: ");
            strNombre = Console.ReadLine();

            Console.Write("Ingrese su edad: ");
            edad = int.Parse(Console.ReadLine());

            string output = string.Format("Su nombre es {0} y tiene {1} años de edad",strNombre,edad );
            Console.WriteLine(output);
            Console.Read();
        }
    }
}
