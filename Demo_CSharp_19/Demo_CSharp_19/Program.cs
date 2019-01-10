using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo_CSharp_19
{
    class Program
    {
        static void Main(string[] args)
        {
            int a = 6;
            int b = 0;

            try
            {
                int c = a / b;
                Console.WriteLine(c);
            }
            catch (DivideByZeroException)
            {
                Console.WriteLine("DivideByZeroException");
            }
            catch (Exception ex)
            {
                Console.WriteLine("Ha habido otro tipo de error");
            }
            finally
            {
                Console.WriteLine("Siempre se va ejecutar esta linea");
            }
            Console.Read();  
        }
    }
}
