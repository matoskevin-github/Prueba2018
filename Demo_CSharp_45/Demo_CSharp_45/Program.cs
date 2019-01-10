using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo_CSharp_45
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> nombres = new List<string>();
            nombres.Add("Felipe");
            nombres.Add("Mario");
            nombres.Add("5");

            List<int> numeros = new List<int>() { 1, 2, 4, 5, 6, 7, 8, 9 };
            numeros.Add(0);
            numeros.Remove(8);
            numeros.RemoveAt(0);
            numeros.RemoveAt(numeros.Count -1);

            numeros.Insert(0, 100);
            numeros.Insert(4, -100);


            Console.Read();
        }
    }
}
