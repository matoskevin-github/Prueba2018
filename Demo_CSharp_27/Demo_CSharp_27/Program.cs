using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo_CSharp_27
{
    class Program
    {
        static void Main(string[] args)
        {
            double promedio = CalcularPromedio(4, 5, 6, 7, 3, 5, 7, 10, 100);
            Console.WriteLine(promedio);
            Console.Read();


        }

        private static double CalcularPromedio(params int[] numeros)
        {
            double suma = 0.0;
            foreach (var numero in numeros)
            {
                suma = suma + numero;
            }
            return suma / numeros.Length;
        }
    }
}
