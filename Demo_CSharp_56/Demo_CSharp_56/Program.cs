using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo_CSharp_56
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> numeros = new List<int>()
            {
                3,5,7,8,2,-3,-100,523,6,2,22
            };

            var numerosMayoresQueCero = numeros.Where(x => x > 0).OrderByDescending(x => x).ToList();
            //  var numerosMayoresQueCeroyPares = numeros.Where(x => x > 0 && x % 2 == 0).ToList();

            List<Persona> personas = new List<Persona>()
            {
                new Persona() {Nombre = "Felipe",Edad = 99,Salario = 5 },
                new Persona() {Nombre = "Claudia",Edad= 35,Salario = 7 },
                new Persona() {Nombre = "Mateo",Edad = 17 ,Salario = 10},
                new Persona() {Nombre = "Patricia",Edad = 12 ,Salario = 1},
                new Persona() {Nombre = "Ana",Edad = 22,Salario = 5 }
            };
            // despues de ordenar se puede reordenar usando ThenBy
            var listaDePersonasOrdenada = personas.OrderBy(x => x.Salario).ThenBy(x => x.Nombre).ToList();
        }
    }

    class Persona
    {
        public string Nombre { get; set; }
        public int Edad { get; set; }

        public decimal Salario { get; set; }
    }
}
