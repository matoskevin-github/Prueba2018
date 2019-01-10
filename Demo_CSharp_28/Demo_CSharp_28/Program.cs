using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo_CSharp_28
{
    class Program
    {
        static void Main(string[] args)
        {
            metodo1("Valor1");
            Console.WriteLine("");
            metodo1("Felipe","Mario");
            Console.Read();
        }

        private static void metodo1(string v)
        {
            metodo1(v, "valor3");
        }

        private static void metodo1(string v1, string v2 = "valor3")
        {
            Console.WriteLine(v1);
            Console.WriteLine(v2);
        }

        
    }
}
