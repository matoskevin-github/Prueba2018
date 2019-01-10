using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo_CSharp_11
{
    class Program
    {
        static void Main(string[] args)
        {
            string nombre = "Felipe";
            string nombreMayuscula = "FELIPE";
            string frase = "Juan y Jose son amigos";9

            var longitudNombre = nombre.Length;

            Console.WriteLine(longitudNombre);
            if(longitudNombre == 6)
            {
                Console.WriteLine(frase.Length);
            }else if(longitudNombre == 7)
            {
                Console.WriteLine("Longitud es 7");
            }else if(longitudNombre == 8)
            {
                Console.WriteLine("Longitud es 8");
                Console.WriteLine("Aqui estamos");
                Console.WriteLine("C# es cool");
                if(nombre.ToUpper() == nombreMayuscula)
                {
                    Console.WriteLine("Los nombres son iguales");
                }
            }else
            {
                Console.WriteLine(nombre == nombreMayuscula);
            }

            Console.Read();
        }
    }
}
