using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClaseNet_15
{
    class Program
    {
        static void Main(string[] args)
        {


            List<string> nombres = new List<string>() {"Maria","Felipe","Leonardo" };
            for(int i = 0;i < nombres.Count;i++)
            {
                Console.WriteLine(nombres[i]);
                  
            }
            /*for(int i = 1; i  <= 10; i++)
            {
                Console.WriteLine(i);  
            }      */
            Console.Read();  
            /*Console.WriteLine(1);
            Console.WriteLine(2);
            Console.WriteLine(3);
            Console.WriteLine(4);
            Console.WriteLine(5);
            Console.WriteLine(6);
            Console.WriteLine(7);
            Console.WriteLine(8);
            Console.WriteLine(9);
            Console.WriteLine(10);
            Console.Read(); */
        }
    }
}
