using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo_CSharp_48
{
    class Program
    {
        static void Main(string[] args)
        {
            Stack<string> stack = new Stack<string>();
            Console.WriteLine("Primer elemento insertado: ");
            Console.WriteLine("A");
            stack.Push("A");

            Console.WriteLine("Segundo elemento insertado: ");
            Console.WriteLine("B");
            stack.Push("B");

            Console.WriteLine("Tercero elemento insertado: ");
            Console.WriteLine("C");
            stack.Push("C");

            Console.WriteLine("Primer elemento extraido");
            Console.WriteLine(stack.Pop());

            Console.WriteLine("Segundo elemento extraido");
            Console.WriteLine(stack.Pop());

            Console.WriteLine("Tercero elemento extraido");
            Console.WriteLine(stack.Pop());

            Console.Read();
        }
    }
}
