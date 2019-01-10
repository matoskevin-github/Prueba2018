using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo_CSharp_50
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> numeros = new List<int>();
            numeros.Add(1);
            numeros.Add(6);
            numeros.Add(345);

            int[] arregloNumeros = new int[3];
            arregloNumeros[0] = 5;
            arregloNumeros[1] = -50;
            arregloNumeros[2] = 100;

            string[] arregloString = new string[] {"FELIPE","C#","JAVASCRIPT","...","PROBLRMA" };
            Array.Resize<string>(ref arregloString, 6);
            arregloString[5] = "Magento";
        }
    }
}
