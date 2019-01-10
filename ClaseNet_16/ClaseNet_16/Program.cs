using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClaseNet_16
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> nombres = new List<string>() {"Felipe","Claudio" };

             for(int i=0; i< nombres.Count;i++)
            {
                Console.WriteLine(nombres[i]);
            }

            /*foreach(string nombre in nombres)
            {
                Console.WriteLine(nombre);
            }   */

            Console.Read();  
        }
    }
}
