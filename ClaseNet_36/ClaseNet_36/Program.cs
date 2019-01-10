using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClaseNet_36
{
    class Program
    {
        static void Main(string[] args)
        {
            var miDobleColeccion = FactoriaDobleColeccion<string, int>(1);
        }

        private static IMiDobleColeccion<T, M> FactoriaDobleColeccion<T, M>(int discriminante)
        {
            if (discriminante == 1)
            {
                return new MiDobleColeccion<T, M>();
            }
            else if (discriminante == 2)
            {
                return new MiDobleColeccionDiccionario<T, M>();
            }
            throw new NotImplementedException();
        }
    }

    interface IMiDobleColeccion<T, M>
    {
        void Agregar(T valorT, M valorM);
    }

    public class MiDobleColeccion<T, M> : IMiDobleColeccion<T, M>
    {
        public List<T> listaT { get; set; }
        public List<M> listaM { get; set; }

        public MiDobleColeccion()
        {
            listaT = new List<T>();
            listaM = new List<M>();
        }

        public void Agregar(T valorT, M valorM)
        {
            listaT.Add(valorT);
            listaM.Add(valorM);
        }
    }

    public class MiDobleColeccionDiccionario<T, M> : IMiDobleColeccion<T, M>
    {
        public Dictionary<T,M > diccionario { get; set; }
        public void Agregar(T valorT, M valorM)
        {
            //...
        }
    }

}
