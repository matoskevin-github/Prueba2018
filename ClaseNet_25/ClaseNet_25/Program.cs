using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClaseNet_25
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Animal> animales = new List<Animal>();
            animales.Add(new Vaca("Roberto"));
            animales.Add(new Oveja("Mario"));

            foreach (var animal in animales)
            {
                animal.HacerRuido();  
            }

            Console.Read(); 
        }
    }

    class Animal
    {
        public string Nombre { get; set; }

        public virtual void HacerRuido()
        {
            Console.WriteLine("{0} hace ruido.",Nombre );
        }
    }

    class Vaca:Animal 
    {
       public Vaca(string nombre)
        {
           Nombre = nombre;
        }

        public override void HacerRuido()
        {
            Console.WriteLine("{0} dice muuu.", Nombre);
        }

        public void Limpiar()
        {
            Console.WriteLine("La vaca {0} ha sido limpiado",Nombre );
        }
    }
    class Oveja  :Animal 
    {
       public Oveja(string nombre)
        {
            Nombre = nombre;
        }

        public void Trazquilar()
        {
            Console.WriteLine("La oveja {0} ha sido trazquilada", Nombre);
        }
    }
}
