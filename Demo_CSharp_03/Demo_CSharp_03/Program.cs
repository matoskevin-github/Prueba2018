using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo_CSharp_03
{
    class Program
    {
        static void Main(string[] args)
        {
            EscribeHolaMundo();
            EscribeEnConsola("Me llamo Felipe");
            IdentificadorDeMetodo("Valor 1","Valor 2",6);
            int sumado1 = 5;
            int sumado2 = 7;
            int resultado = suma(sumado1, sumado2);
            Console.WriteLine(resultado);
            Console.Read();
        }

        private static int suma(int sumado1, int sumado2)
        {
            return sumado1 + sumado2;
        }

        private static void IdentificadorDeMetodo(string v1, string v2, int v3)
        {
          
        }

        private static void EscribeEnConsola(string valor)
        {
            Console.WriteLine(valor);
        }

        private static void EscribeHolaMundo()
        {
            Console.WriteLine("Hola Mundo");
        }
    }
}
