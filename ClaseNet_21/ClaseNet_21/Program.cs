using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClaseNet_21
{
    class Program
    {
        static void Main(string[] args)
        {
            var ve = new Vector(new List<int> {1,2,3 });
        }
    }

    class Vector
    {
        private List<int> _valores;

        public Vector (List<int> valores)
        {
            _valores = valores;
        }
    }

}
