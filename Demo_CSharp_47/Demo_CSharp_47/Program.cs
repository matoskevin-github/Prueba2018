using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo_CSharp_47
{
    class Program
    {
        static void Main(string[] args)
        {
            Queue<string> queue = new Queue<string>();
            Console.WriteLine("Primer elemento insertado");
            Console.WriteLine("Primero");
            queue.Enqueue("Primero");

            Console.WriteLine("Segundo elemento insertado");
            Console.WriteLine("Segundo");
            queue.Enqueue("Segundo");

            Console.WriteLine("Tercero elemento insertado");
            Console.WriteLine("Tercero");
            queue.Enqueue("Tercero");

            Console.WriteLine("");

            //Podemos iterar el queue para leer su contenido
            //El queue esta vacio en este momento
            foreach (var item in queue)
            {
                Console.WriteLine(item);
            }
            Console.WriteLine("");

            Console.WriteLine("Primer elemento extraido");
            Console.WriteLine(queue.Dequeue());

            Console.WriteLine("Segundo elemento extraido");
            Console.WriteLine(queue.Dequeue());

            Console.WriteLine("Tercero elemento extraido");
            Console.WriteLine(queue.Dequeue());
            Console.Read();
        }
    }
}
