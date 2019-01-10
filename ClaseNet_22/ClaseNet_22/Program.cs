using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClaseNet_22
{
    class Program
    {
        static void Main(string[] args)
        {
            var v2 = new Vector(new List<int> { 1,2 });
            Console.WriteLine(v2.Componentes.ToString());
            Console.WriteLine(v2.dimension );
            v2.Nombre = "Vector 1";
            Console.Read();  

        }
    }

  public  class Vector
    {
        private List<int> _componentes;

       public Vector(List<int> componentes)
        {
            _componentes = componentes;
        }

        public List<int> Componentes
        {
            get
            {
                return _componentes;
            }
        }

        public int dimension
        {
            get
            {
              return   _componentes.Count;  
            }
        }

        public string Nombre { get; set; }
    }
}
