using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo_CSharp_23
{
    class Program
    {
        static void Main(string[] args)
        {
            var v2 = new Vector(new List<int> { 1, 2 });
        }
    }
    class Vector
    {
        private List<int> _valores;
        public Vector(List<int> valores)
        {
            _valores = valores;
        }
    }
}
