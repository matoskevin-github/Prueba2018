using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo_CSharp_46
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, int> NombreEdad = new Dictionary<string, int>();
            NombreEdad.Add("Felipe", 85);
            NombreEdad.Add("Roberto", 40);
            NombreEdad.Add("Maria", 40);

            Console.WriteLine(NombreEdad["Roberto"]);

            if (NombreEdad.ContainsKey("blablabla"))
            {
                Console.WriteLine(NombreEdad["blablabla"]);
            }

            NombreEdad.Remove("Roberto");

            Dictionary<int, Persona> personas = new Dictionary<int, Persona>();

            foreach (var item in NombreEdad.Keys)
            {

            }

            Console.Read();
        }
    }
    class Persona
    {
        public int MyProperty1 { get; set; }
        public int MyProperty2 { get; set; }
    }
}
