using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppGenericos
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> lstpaises = new List<string>();
            lstpaises.Add("Colombia");
            lstpaises.Add("Argentina");
            lstpaises.Add("Holanda");

            foreach(string item in lstpaises)
            {
                Console.WriteLine(item);
            }
            Console.WriteLine("");
            lstpaises.Remove ("Argentina");

            foreach (string item in lstpaises)
            {
                Console.WriteLine(item);
            }
            Console.WriteLine("");
            List<string> lstNuevoListado = new List<string>();
            lstNuevoListado.Add("Otro Pais");
            lstNuevoListado.AddRange(lstpaises);

            foreach (string item in lstNuevoListado)
            {
                Console.WriteLine(item);
            }
            lstNuevoListado.RemoveRange(0, 2);
            Console.WriteLine("");
            foreach (string item in lstNuevoListado)
            {
                Console.WriteLine(item);
            }
            Console.Read();
        }
    }
}
