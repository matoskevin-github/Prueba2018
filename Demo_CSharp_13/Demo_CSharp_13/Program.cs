using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo_CSharp_13
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> nombres = new List<string>() { "Felipe","Claudio"};
            foreach (string item in nombres)
            {
                Console.WriteLine(item.ToUpper());
            }
            Console.Read(); 
        }
    }
}
