using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClaseNet_23
{
    class Program
    {
        static void Main(string[] args)
        {
            double numero1 = 5;
            double numero2 = 7;
            double numero3 = 10;
            double promedio = CalcularPromedio(numero1,numero2, numero3)  ;

        }

        private static double CalcularPromedio(double numero1, double numero2, double numero3)
        {
            return ((numero1 + numero2 + numero3) / 3);
        }

        private static double CalcularPromedio(int numero1, int numero2, int numero3)
        {
            return ((numero1 + numero2 + numero3) / 3);
        }
    }
}

