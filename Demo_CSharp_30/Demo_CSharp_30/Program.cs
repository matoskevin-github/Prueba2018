using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo_CSharp_30
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Animal> animales = new List<Animal>();
            animales.Add(new Vaca("Roberto"));
            animales.Add(new Oveja("Mario"));

            foreach (var item in animales)
            {
                item.HacerRuido();
            }
            Console.Read();
        }
    }

    class Animal
    {
        public string Nombre { get; set; }

        public virtual void HacerRuido()
        {
            Console.WriteLine("{0} hace ruido",Nombre);
        }
    }

    class Vaca : Animal
    {
        public Vaca(string nombre)
        {
            Nombre = nombre;
        }

        public void HacerRuido()
        {
            Console.WriteLine("{0} DICE MUUUU", Nombre);
        }

        public void Limpiar()
        {
            Console.WriteLine("LA VACA {0} HA SIDO LIMPIADA", Nombre);
        }
    }

    class Oveja : Animal
    {
        public Oveja(string nombre)
        {
            Nombre = nombre;
        }

        public void HacerRuido()
        {
            Console.WriteLine("{0} DICE VEEEEH", Nombre);
        }

        public void Trazquilar()
        {
            Console.WriteLine("LA OVEJA {0} HA SIDO TRAZQUILADA", Nombre);
        }
    }
}
