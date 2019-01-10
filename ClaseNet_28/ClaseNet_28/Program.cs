using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClaseNet_28
{
    class Program
    {
        static void Main(string[] args)
        {
            Object o = DateTime.Today;
            
            if(o is DateTime )
            {
                var fecha = (DateTime)o;

            }   else if(o is string)
            {
                var unString = (string)o;
            }
        }
    }
}
