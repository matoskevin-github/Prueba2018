using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo_CSharp_15
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> nombres = new List<string>();

            for (int i = 0; i < 10; i++)
            {
                if (i == 5)
                {
                    //continue;
                    break; 
                }
                Console.WriteLine(i); 
            }
            Console.Read();
        }
    }
}
