using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClaseNet_03
{
    class Program
    {
        static void Main(string[] args)
        {
            EscribeHolaMundo();
            EscribeEnConsola("Me llamo felipe");
            int sumado1 = 5;
            int sumado2 = 7;
            int resultado = Suma(sumado1, sumado2); 
            Console.Read();  
        }

        static int Suma(int a, int b)
        {
            return a + b;
        }

        private static void EscribeEnConsola(string v)
        {
            Console.WriteLine(v);
        }

        private static void EscribeHolaMundo()
        {
            Console.WriteLine("Hola Mundo");  
        }
    }
}
