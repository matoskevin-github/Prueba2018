using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo_CSharp_61
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> numeros = new List<int>()
            {
                3,5,7,8,2,-3,-100,523,6,2,22
            };

            var listado = numeros.TakeWhile(x => x < 6).ToList();
            var listado2 = numeros.SkipWhile(x => x < 6).ToList();

            Console.Read();

        }
    }
}
