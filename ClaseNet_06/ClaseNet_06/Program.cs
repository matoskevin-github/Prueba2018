using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClaseNet_06
{
    class Program
    {
        static void Main(string[] args)
        {
            var nombre = "Felipe";
            var mes = 5;
            var procesoTerminado = false;

            string direccion;

            var p = new Persona();
            p.Nombre = "Felipe";
            
        }
    }
    class Persona
    {
        public string Nombre;
        public int Edad;
        public string Direccion;

        public void MostrarDatosConsola()
        {
            string output = "El nombre es {0}, es la edad es {1} y su direccion es {2}";
            output = string.Format(output, Nombre, Edad, Direccion);
            Console.Read();  
        }
    }
}
