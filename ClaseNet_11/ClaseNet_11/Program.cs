using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClaseNet_11
{
    class Program
    {
        static void Main(string[] args)
        {
            string nombre = "Felipe";

            nombre = "Juan";

            Console.Read();  
        }
   
    }

    class Persona
    {
        public string nombre;
        private int edad;

        public int obtenerEdad()
        {
            return edad;
        }
    }
}
