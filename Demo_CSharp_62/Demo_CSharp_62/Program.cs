using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo_CSharp_62
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> numeros = new List<int>()
            {
                3,5,7,8,2,-3,-100,523,6,2,22
            };

            var grupo = numeros.GroupBy(x => Math.Abs(x % 2));

            foreach (var item in grupo)
            {
                Console.WriteLine("Numeros cuyo residuo es: " + item.Key);
                foreach (var numero in item)
                {
                    Console.WriteLine(numero);
                }
                Console.WriteLine("");
            }

            List<Persona> personas = new List<Persona>()
            {
                new Persona() {Nombre = "Felipe",Edad = 99,Salario = 5 },
                new Persona() {Nombre = "Claudia",Edad= 35,Salario = 7 },
                new Persona() {Nombre = "Mateo",Edad = 17 ,Salario = 10},
                new Persona() {Nombre = "Patricia",Edad = 12 ,Salario = 1},
                new Persona() {Nombre = "Ana",Edad = 22,Salario = 5 }
            };

            var grupoPersonas = personas.GroupBy(x =>
            {
                if (x.Edad <= 20)
                {
                    return "Menor que 20";
                }
                else if (x.Edad >= 21 && x.Edad <= 40)
                {
                    return "Entre 21 y 40";
                }
                else
                {
                    return "Mayores que 41";
                }
            });

            foreach (var grupoPersona in grupoPersonas)
            {
                Console.WriteLine("Grupo de :"+grupoPersona.Key + " -- Cantidad: " + grupoPersona.Count() );
                foreach (Persona persona in grupoPersona)
                {
                    Console.WriteLine(persona.Nombre);
                }
                Console.WriteLine("");
            }

            Console.Read();
        }
    }

    class Persona
    {
        public string Nombre { get; set; }
        public int Edad { get; set; }
        public decimal Salario { get; set; }
    }
}
