using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo_CSharp_34
{
    class Program
    {
        static void Main(string[] args)
        {
            Object o = "hola";
            if (o is DateTime)
            {
                var fecha = (DateTime)o;
            }
            else if (o is string)
            {
                var unString = (string)o;
            }
            Console.Read();
        }
    }
}
