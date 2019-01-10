using System;
using System.Configuration;

namespace Demo_CSharp_67
{
    class Program
    {
        static void Main(string[] args)
        {
            var valor = ConfigurationManager.AppSettings["mensaje"];
            Console.WriteLine(valor);
            Console.Read();

        }
    }
}
