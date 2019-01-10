using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo_CSharp_14
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> nombres = new List<string>() {"Leonardo","Josefina","Felipe","Maria" };
            int j = 0;
            while (j < nombres.Count )
            {
                Console.WriteLine(nombres[j].ToUpper());
                j++;
            }
            Console.Read(); 
        }
    }
}
