using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClaseNet_33
{
    class Program
    {
        static void Main(string[] args)
        {
            var persona = new Persona() {Nombre = "Felipe" };
            
            //Tipo de referencia
            Console.WriteLine("--Tipo de referencia--");
            Console.WriteLine("Previo al cambio");
            Console.WriteLine(persona.Nombre );
            EditarPersona(persona, "Roberto");
            Console.WriteLine("Despues del cambio");
            Console.WriteLine(persona.Nombre);

            Console.WriteLine("");

            //Tipo de valor
            Console.WriteLine("--Tipo de valor--");
            Console.WriteLine("Previo al cambio");
            int edad = 9;
            Console.WriteLine(edad);
            EditarEdad(ref edad, 14);
            Console.WriteLine("Despues del cambio");
            Console.WriteLine(edad);

            Console.Read();
        }

        private static void EditarEdad(ref int edadActual, int nuevaEdad)
        {
            edadActual = nuevaEdad;
        }

        private static void EditarPersona(Persona persona, string nuevoNombre)
        {
            persona.Nombre = nuevoNombre;
        }
    }

    class Persona
    {
        public string Nombre { get; set; }
    }
}
