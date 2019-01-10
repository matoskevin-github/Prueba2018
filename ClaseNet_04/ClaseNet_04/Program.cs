using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClaseNet_04
{
    class Program
    {
        static void Main(string[] args)
        {
            PreguntarNombreEdad();

            Console.Read();    
        }

        static void PreguntarNombreEdad()
        {

            string strNombre = string.Empty;
            int edad;
            Console.Write("Ingrese su nombre:");
            strNombre = Console.ReadLine();
            Console.WriteLine("Ingrese su edad:");
            edad = int.Parse(Console.ReadLine());

            string strOutPut = string.Format("Su nombre es {0} y tiene {1} años de edad", strNombre, edad);
            Console.WriteLine(strOutPut);
        }
    }
}
