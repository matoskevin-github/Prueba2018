using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo_CSharp_12
{
    public class Program
    {
        static void Main(string[] args)
        {
            /*for (int i = 0; i <= 10; i++)
            {
                Console.WriteLine(i);
            }*/

            List<string> nombres = new List<string>() {"Felipe","Maria","Leonarda" };
            for (int i = 0; i < nombres.Count; i++)
            {
                Console.WriteLine(nombres[i].ToUpper());                     
            }
            Console.Read();
        }
    }
}
