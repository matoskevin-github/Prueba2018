using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo_CSharp_43
{
    public class Program
    {
        static void Main(string[] args)
        {
            var miDobleColeccion = FactoriaDobleColeccion<string, int>(1);
            miDobleColeccion.Agregar("Felipe", 7); 
        }

        private static IMiDoubleColeccion<T, M> FactoriaDobleColeccion<T, M>(int discriminante)
        {
            if (discriminante == 1)
            {
                return new MiDobleColeccion<T, M>();
            }
            else if (discriminante == 2)
            {
                return new MiDobleColeccion<T, M>();
            }
            else
            {

            }
            return null;
        }
    }

    public interface IMiDoubleColeccion<T, M>
    {
        void Agregar(T valorT, M valorM);
    }

    class MiDobleColeccion<T, M> : IMiDoubleColeccion<T, M>
    {
        public List<T> MyListaDeT { get; set; }
        public List<M> MyListaDeM { get; set; }

        public MiDobleColeccion()
        {
            MyListaDeT = new List<T>();
            MyListaDeM = new List<M>();
        }

        public void Agregar(T valorT, M valorM)
        {
            MyListaDeT.Add(valorT);
            MyListaDeM.Add(valorM);
        }
    }
}
