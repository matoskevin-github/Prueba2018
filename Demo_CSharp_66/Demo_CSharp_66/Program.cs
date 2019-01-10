using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo_CSharp_66
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> numeros = new List<int>()
            {
                2,3,4,5
            };

            var producto = numeros.Aggregate((anterior, actual) => anterior * actual);

        }
    }
}
