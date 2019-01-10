using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo_CSharp_22
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                Console.WriteLine("Escriba un numero: ");
                int numero1 = int.Parse(Console.ReadLine());
                Console.WriteLine("Escriba otro numero: ");
                int numero2 = int.Parse(Console.ReadLine());
                Console.WriteLine("El numero mas grande es: ");

                if (numero1 > numero2)
                {
                    Console.WriteLine(numero1);
                }
                else
                {
                    Console.WriteLine(numero2);
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Mensaje => " + ex.ToString());
            }
            Console.Read(); 
        }
    }
}
