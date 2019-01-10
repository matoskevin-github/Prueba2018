using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClaseNet_12
{
    class Program
    {
        static void Main(string[] args)
        {
            string nombre = "Felipe";
            string frase = "Juan y Jose son amigos";

            //Length
            Console.WriteLine(nombre.Length);
            Console.WriteLine(frase.Length);

            //SubString
            Console.WriteLine(nombre.Substring(3));
            Console.WriteLine(frase.Substring(7, 4));

            //StarsWith
            Console.WriteLine(frase.StartsWith("Juan"));
            Console.WriteLine(frase.StartsWith("Jose"));

            //EndsWith 
            Console.WriteLine(frase.EndsWith ("Juan"));
            Console.WriteLine(frase.EndsWith("Jose"));

            //Contains
            Console.WriteLine(frase.Contains ("Jose"));
            Console.WriteLine(frase.Contains("Pedro"));

            string frase2 = "Juan y jose son amigos";

            //indexof
            var indiceDeJose = frase2.IndexOf("Jose");
            var indiceDePedro = frase2.IndexOf("Pedro");

            Console.WriteLine(indiceDeJose );
            Console.WriteLine(indiceDePedro);

            //operador +

            Console.WriteLine(nombre + ", " + frase);

            //ToLower

            Console.WriteLine(frase.ToLower());

            //ToUpper
            Console.WriteLine(frase.ToUpper());

            //Trim
            string ejemploTrim = "  Felipe  ";
            Console.WriteLine(ejemploTrim);
            Console.WriteLine(ejemploTrim.Trim ());
            Console.WriteLine(nombre == ejemploTrim );
            Console.WriteLine(nombre == ejemploTrim.Trim() );


            //Format
            string ejemploFormat = "Felicidades  {0} en tu cumpleaños numer{1}! {0}";


            //Replace
            string ejemploReplace = "Felicidades @nombre en tu cumpleaños numero @edad ";

            Console.Read();

        }
    }
}
