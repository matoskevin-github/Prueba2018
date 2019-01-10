using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClaseNet_17
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> nombres = new List<string>() {"Kevin","Matos","Secce" };
            int j = 0;
            while (j < nombres.Count  )
            {
                Console.WriteLine(nombres[j].ToUpper() );
                j++;
            }
            Console.Read();    
        }
    }
}
