using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClaseNet_09
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Operaciones Logicas");
            var booleano = true;
            Console.WriteLine("Operacion Negacion !{0} = {1}", booleano, !booleano);
            Console.WriteLine("");

            Console.WriteLine("Conjuncion");
            Console.WriteLine("{0} & {0} = {1}", true, true & true);
            Console.WriteLine("{0} & {0} = {1}", false, false & false);
            Console.WriteLine("{0} & {1} = {2}", true, false, true & false);

            Console.WriteLine("");

            Console.WriteLine("Disyuncion exclusiva");
            Console.WriteLine("{0} ^ {0} = {1}", true, true ^ true);
            Console.WriteLine("{0} ^ {0} = {1}", false, false ^ false);
            Console.WriteLine("{0} ^ {1} = {2}", true, false, true ^ false);

            Console.WriteLine("");

            Console.WriteLine("Disyuncion inclusiva");
            Console.WriteLine("{0} | {0} = {1}", true, true | true);
            Console.WriteLine("{0} | {1} = {2}", true,false, true | false);
            Console.WriteLine("{0} | {1} = {2}", false, false, false | false);

            Console.Read();  
        }
    }
}

