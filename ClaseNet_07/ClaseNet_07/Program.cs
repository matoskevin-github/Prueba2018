using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClaseNet_07
{
    class Program
    {
        static void Main(string[] args)
        {
            var a = 1;
            var b = 2;
            var c = 8;
            var d = 9;
            Console.WriteLine("{0} + {1} = {2}", a, b, a + b);
            Console.WriteLine("{0} - {1} = {2}", c, a, c - a);
            Console.WriteLine("{0} * {1} = {2}", b, c, b * c);
            Console.WriteLine("{0} / {1} = {2}", c, b, c / b);
            Console.WriteLine("{0} / {1} = {2}", a, b, a / b);
            Console.WriteLine("{0} / {1} = {2}", "1.0", b, 1.0 / b);

            Console.WriteLine("");
            // Incremento en 1 el valor de a
            a++;
            Console.WriteLine("El incremento de {0} es {1} pues x++ = x + 1", a - 1, a);

            //Disminuyendo en 1 al valor de a 
            a--;
            Console.WriteLine("El incremento de {0} es {1} pues x-- = x - 1", a + 1, a);

            Console.WriteLine("");
            Console.WriteLine("Residuos");
            Console.WriteLine("{0} % {1} = {2}", b, a, b % a);
            Console.WriteLine("{0} % {1} = {2}", d, b, d % b);

            Console.Read(); 
        }
    }
}
