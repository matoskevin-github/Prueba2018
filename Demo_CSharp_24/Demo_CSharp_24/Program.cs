using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo_CSharp_24
{
    class Program
    {
        static void Main(string[] args)
        {
            var v2 = new Vector(new List<int> { 1, 2 });
            Console.WriteLine(v2.Componentes.ToString());
            Console.WriteLine(v2.Dimension);
            v2.Nombre = "Vector 1";
            Console.WriteLine(v2.Nombre);
            Console.Read();
        }
    }

    class Vector
    {
        private List<int> _componentes;

        public List<int> Componentes
        {
            get { return _componentes; }
            set { _componentes = value; }
        }

        public int Dimension
        {
            get
            {
                return _componentes.Count;
            }
        }
        public string Nombre { get; internal set; }

        public Vector(List<int> componentes)
        {
            _componentes = componentes;
        }

    }
}
