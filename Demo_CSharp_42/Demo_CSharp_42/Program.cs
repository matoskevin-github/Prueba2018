using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo_CSharp_42
{
    class Program
    {
        static void Main(string[] args)
        {
            MiColeccion<decimal, string> miColeccion = new MiColeccion<decimal, string>();
            miColeccion.Agregar(20m);
            miColeccion.Agregar("Felipe");
        }
    }

    class MiColeccion<T,M>
    {
        public List<T> MyLista { get; set; }

        public MiColeccion()
        {
            MyLista = new List<T>();
        }

        public void Agregar(T valor)
        {
            MyLista.Add(valor);
        }

        public void Agregar(M valor)
        {

        }
    }
}
