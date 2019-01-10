using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClaseNet_24
{
    class Program
    {
        static void Main(string[] args)
        {
            double promedio = CalcularPromedio(4,5,6,7,3,7,10);

        }


        public static double CalcularPromedio(params int[] numeros)
        {
            double suma = 0;
            foreach(var numero in numeros)
            {
                suma = suma + numero;
            }
            return suma / numeros.Length; 
        }
    }
}
