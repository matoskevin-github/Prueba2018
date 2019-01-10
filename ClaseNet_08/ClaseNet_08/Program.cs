using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClaseNet_08
{
    class Program
    {
        static void Main(string[] args)
        {
            var a = 1;
            var b = 2;
            var c = 8;
            var d = 9;

            Console.WriteLine("Operaciones de Relacion");

            Console.WriteLine("{0} == {1} es {2}", a, b, a == b);
            Console.WriteLine("{0} == {0} es {1}", a, a == a);

            Console.WriteLine("{0} != {1} es {2}", c, d, c != d);
            Console.WriteLine("{0} != {0} es {1}", b, b != b);

            Console.WriteLine("{0} < {1} es {2}", a, b, a < b);
            Console.WriteLine("{0} < {1} es {2}", c, a, c < a);

            Console.WriteLine("{0} > {1} es {2}", a, b, a > b);
            Console.WriteLine("{0} > {1} es {2}", d, b, d > b);

            Console.WriteLine("{0} <= {1} es {2}", c,d,c <= d);
            Console.WriteLine("{0} <= {0} es {1}", b, b <= b);

            Console.WriteLine("{0} >= {1} es {2}", c, d, c >= d);
            Console.WriteLine("{0} >= {0} es {1}", a, a >= a);

            Console.WriteLine("{0} is int es {1}",a,a is int);
            Console.WriteLine("{0} is string es {1}", a, a is string);

            Console.Read(); 
        }
    }
}
