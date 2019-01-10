using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo_CSharp_40
{
    class Program
    {
        static void Main(string[] args)
        {
            //Tipo de referencia
            var persona = new Persona() { Nombre = "Felipe" };
            Console.WriteLine("--Tipo de referencia--");
            Console.WriteLine("Previo al cambio");
            Console.WriteLine(persona.Nombre);
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

        private static void EditarEdad(ref int edad, int nuevaEdad)
        {
            edad = nuevaEdad;
        }

        private static void EditarPersona(Persona persona, string nuevoNombre)
        {
            persona.Nombre = nuevoNombre;
        }
    }

    public class Persona
    {
        public string Nombre { get; set; }
    }
}
