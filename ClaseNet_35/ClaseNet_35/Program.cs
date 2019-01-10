using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClaseNet_35
{
    class Program
    {
        static void Main(string[] args)
        {
            MiColeccion<decimal, string> objColeccion = new MiColeccion<decimal, string>();
            objColeccion.Agregar(20);
            objColeccion.Agregar("Kevin");
        }
    }

    class MiColeccion <T,M>
    {
        public List<T>  MyLista { get; set; }

        public MiColeccion()
        {
            MyLista = new List<T>();
        }
        public void Agregar(T valor)
        {
            MyLista.Add(valor );
        }

        public void Agregar(M valor)
        {
            
        }
    }
}
