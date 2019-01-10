using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo_CSharp_63
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> lstnumeros1 = new List<int>()
            {
                3,5,7,8,2,-3,-100,523,6,2,22
            };

            List<int> lstnumeros2 = new List<int>()
            {
              2,4,8,16,32,64
            };

            var sonParesTodos1 = lstnumeros1.All(x => x % 2 == 0);
            var sonParesTodos2 = lstnumeros2.All(x => x % 2 == 0);

            var existeAlgunImpar = lstnumeros1.Any(x => x % 2 == 0);
            var existeAlgunNumeroMayorA1000 = lstnumeros1.Any(x => x > 1000);


        }
    }
}
