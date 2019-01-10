using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo_CSharp_52
{
    class Program
    {
        static void Main(string[] args)
        {
            Func<int, int> duplicar = x => { return x * 2; };
            Func<int, int, int> multiplicar = (x, y) => { return x * y; };

            Console.WriteLine(duplicar(35));
            Console.WriteLine(multiplicar(4,5));
            Console.Read();
        }
    }
}
