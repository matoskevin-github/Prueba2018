using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo_CSharp_65
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> numeros = new List<int>()
            {
                3,5,7,8,2,-3,-100,523,6,2,22
            };

            var min = numeros.Min();
            var max = numeros.Max();
            var promedio = numeros.Average();

            List<Persona> personas = new List<Persona>()
            {
                new Persona() {Nombre = "Felipe",Edad = 99,Salario = 5 },
                new Persona() {Nombre = "Claudia",Edad= 35,Salario = 7 },
                new Persona() {Nombre = "Mateo",Edad = 17 ,Salario = 10},
                new Persona() {Nombre = "Patricia",Edad = 12 ,Salario = 1},
                new Persona() {Nombre = "Ana",Edad = 22,Salario = 5 }
            };

            var salarioMinimo = personas.Min(x => x.Salario);
            var salarioMaximo = personas.Max(x => x.Salario);
            var promedioEdad = personas.Average(x => x.Salario);



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
