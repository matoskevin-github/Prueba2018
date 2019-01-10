using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClaseNet_34
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> numeros = new List<int> { 1, 2, 3, 4, 5 };

            List<Persona> personas = new List<Persona>()
            {
                new Persona() {Nombre = "Felipe" } ,
                new Persona() {Nombre = "Carla" }
            }; 
            
        }
    }

    class Persona
    {
        public string Nombre { get; set; }
    }
}
