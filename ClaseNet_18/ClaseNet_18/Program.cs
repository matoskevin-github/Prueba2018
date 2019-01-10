using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClaseNet_18
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> nombres = new List<string>();

            for(int i = 1; i < 10; i++)
            {
                Console.WriteLine(i);
                if(i == 5)
                {
                    break;
                }
            }
            Console.Read();  
        }
    }
}
