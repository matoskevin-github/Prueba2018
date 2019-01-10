using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo_CSharp_05
{
    class Program
    {
        static void Main(string[] args)
        {
            Persona p = new Persona();
            p.Nombre = "Victor";
            p.Edad = 35;
            p.Direccion = "Av. Jose Larco 880";
            p.MostrarDatosEnConsola();
            Console.Read();
        }
    }

    class Persona
    {
        public string Nombre;
        public int Edad;
        public string Direccion;

        public void MostrarDatosEnConsola()
        {
            string output = "El nombre es {0}, la edad es {1} y su direccion es {2}";
            output = string.Format(output, Nombre, Edad, Direccion);
            Console.WriteLine(output); 
        }
    }
}
