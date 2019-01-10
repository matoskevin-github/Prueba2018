using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo_CSharp_53
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> numeros = new List<int>()
            {
                3,5,7,8,2,-3,-100,523,6,2,22
            };

            var result = numeros.Where(x => x > 0).ToList();

            Console.Read();
        }
    }

    class Persona
    {
        public string Nombre { get; set; }
        public int Edad { get; set; }
    }
}
