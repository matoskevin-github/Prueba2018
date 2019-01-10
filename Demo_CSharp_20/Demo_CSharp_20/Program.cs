using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo_CSharp_20
{
    class Program
    {
        static void Main(string[] args)
        {
            var persona = new Persona()
            {
                nombre = "Felipe",
                edad = 90
            };
            persona = null;

            Nullable<int> numero = 45;
            numero = null;
            DateTime? fechaNacimiento = null;
            fechaNacimiento = new DateTime(2015, 1, 1);

            if (numero.HasValue)
            {
                Console.WriteLine("El numero tiene valor");
            }

            if (fechaNacimiento.HasValue)
            {
                Console.WriteLine("La fecha tiene valor");
            }
            Console.Read();
        }
    }

    class Persona
    {
        public string nombre;
        public int edad;
    }
}
