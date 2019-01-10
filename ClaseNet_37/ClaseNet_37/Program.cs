using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClaseNet_37
{
    class Program
    {
        static void Main(string[] args)
        {
        }

        static void Generico_struct<T>(T valor)where T : struct
        {

        }

        static M Generico_class<M>()where M : class, new()
         {
            return new M();
        } 

        static void Generico_interface<T>(T implementacion) where T:IEnumerable<T>
        {
            foreach (var item in implementacion  )
            {

            }
        }

        static C Generico_constructor<C>() where C : new()
        {
            return new C();
        }

        static void Generico_Herencia<A>(A animal) where A : Animal
        {
            animal.HacerRuido();  
        }

    }

    class Animal
    {
         public void HacerRuido()
        {

        }
    }
}
