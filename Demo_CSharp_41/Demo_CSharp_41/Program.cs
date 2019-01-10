using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo_CSharp_41
{
    class Program
    {
        static void Main(string[] args)
        {
            // la clase sealed evita el instacimiento de una clase

            List<int> numros = new List<int>() { 1,2,3,4,5};
            numros.Add(6);
            List<Persona> persona = new List<Persona>()
            {
                new Persona() { Nombre = "Felipe"},
                new Persona() { Nombre = "Carla"}
            };
        }
    }

     class Persona
    {
        public string Nombre { get; set; }
    }
}
