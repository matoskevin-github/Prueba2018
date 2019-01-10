using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo_CSharp_49
{
    class Program
    {
        static void Main(string[] args)
        {
            HashSet<int> conjunto1 = new HashSet<int>();
            conjunto1.Add(5);
            conjunto1.Add(6);

            HashSet<int> conjunto2 = new HashSet<int>();
            conjunto2.Add(5);
            conjunto2.Add(8);

            HashSet<int> union_set1_set2 = new HashSet<int>(conjunto1);
            union_set1_set2.UnionWith(conjunto2);

            HashSet<int> interseccion_set1_set2 = new HashSet<int>(conjunto1);
            interseccion_set1_set2.ExceptWith(conjunto2);

            HashSet<int> diferencia_simetrica_set1_set2 = new HashSet<int>(conjunto1);
            diferencia_simetrica_set1_set2.SymmetricExceptWith(conjunto2);

            List<int> numeros = new List<int>() { 1, 2, 3, 4, 5, 6, 7, 8, 9, 0, 10, 11, 12, 13, 14, 15, 16, 17, 18, 19, 20 };
            numeros = new HashSet<int>(numeros).ToList();
        }
    }
}
