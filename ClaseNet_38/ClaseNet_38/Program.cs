using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClaseNet_38
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> nombres = new List<string>();
            nombres.Add("Felipe");
            nombres.Add("Mario");
            nombres.Add("5");

            List<int> numeros = new List<int>() { 1, 5, 7, 8, -3, 6, 2, 4, 6 };
            numeros.Add(0);

            numeros.Remove (8);
            numeros.RemoveAt(0);
            numeros.RemoveAt(numeros.Count - 1);

            numeros.Insert(0, 100);
            numeros.Insert(4, -100);
            var primerElementoLista = numeros[0];
            var ultimoElementoLista = numeros[numeros.Count - 1];

        }
    }
}
