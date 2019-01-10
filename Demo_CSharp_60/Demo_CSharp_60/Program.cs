using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo_CSharp_60
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> numeros = new List<int>()
            {
                3,5,7,8,2,-3,-100,523,6,2,22
            };

            var PrimerElemento = numeros.Skip(2).Take(3).ToList();
            var elemt = numeros.Where(x => x > 4).Skip(2).Take(3).ToList(); 

            Console.Read();  
        }
    }
}
