using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo_CSharp_32
{
    class Program
    {
        static void Main(string[] args)
        {
            Animal perro = new Perro();
            Animal gato = new Gato();
            Animal pelicano = new Pelicano();
            Animal gusano = new Gusano();
            AnimalHacerRuido(perro);
            AnimalHacerRuido(gato);
            AnimalHacerRuido(pelicano);
            AnimalHacerRuido(gusano);
            Console.Read();
        }

        private static void AnimalHacerRuido(Animal oAnimal)
        {
            oAnimal.HacerRuido();
        }
    }

    class Animal
    {
        public virtual void HacerRuido()
        {
            Console.WriteLine("Ruido Genérico");
        }

        protected  void MetodoProtegido()
        {

        }
    }

    class Perro:Animal
    {
        public override void HacerRuido()
        {
            Console.WriteLine("Ruido Genérico");
            MetodoProtegido();
        }

        public void ElBaile()
        {
            Console.WriteLine("Del perrito");
        }
    }

    class Gato : Animal
    {
        public override void HacerRuido()
        {
            Console.WriteLine("Miau");
        }
    }

    class Pelicano : Animal
    {
        public override void HacerRuido()
        {
            base.HacerRuido();
        }
    }

    class Gusano : Animal
    {

    }
}
