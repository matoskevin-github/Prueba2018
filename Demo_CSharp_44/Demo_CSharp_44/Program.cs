using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo_CSharp_44
{
    class Program
    {
        static void Main(string[] args)
        {
            Generico_struct<int>(5);
            Generico_class<Perro>();
        }



        private static void Generico_struct<T>(T valor) where T : struct
        {
            throw new NotImplementedException();
        }

        private static void Generico_class<M>() where M : class, new()
        {
            throw new NotImplementedException();
        }

        static void Generico_Interface<T>(T implementacion) where T : IEnumerable<T>
        {
            foreach (T item in implementacion)
            {

            }
        }

        static C Generico_Constructor<C>() where C : new()
        {
            return new C();
        }

        static void Generico_Herencia<A>(A animal) where A : Animal
        {

        }
    }

    class Animal
    {

    }

    class Perro
    {

    }
}
