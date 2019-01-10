using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo_CSharp_36
{
    class Program
    {
        static void Main(string[] args)
        {
            var animalito1 = new {animal = "Perro",nombre = "Roberto",vidas = 1 };
            var animalito2 = new { animal = "Gato", nombre = "Alexander", vidas = 7 };
            List<dynamic> animalitos = new List<dynamic>();
            animalitos.Add(animalito1);
            animalitos.Add(animalito2);

            foreach (dynamic item in animalitos)
            {
                Console.WriteLine("El {0} de nombre {1} tiene {2} vidas",item.animal, item.nombre, item.vidas);
            }
            Console.Read();
        }
    }

    class Persona
    {
        public string Nombre { get; set; }
        public int Edad { get; set; }
    }
}
