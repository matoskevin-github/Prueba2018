using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo_CSharp_10
{
    class Program
    {
        static void Main(string[] args)
        {
            string nombre = "Felipe";
            string nombreMayuscula = "FELIPE";
            string frase = "Juan y Jose son amigos";

            Console.WriteLine(nombre.ToUpper() == nombreMayuscula);

            //Length
            Console.WriteLine(nombre.Length);
            Console.WriteLine(frase.Length);

            //SubString
            Console.WriteLine(nombre.Substring(3));
            Console.WriteLine(frase.Substring(7, 4));

            //startwith
            Console.WriteLine(frase.StartsWith("Juan"));
            Console.WriteLine(frase.StartsWith("Jose"));

            //endswith
            Console.WriteLine(frase.EndsWith("amigos"));
            Console.WriteLine(frase.EndsWith("enemigos"));

            //contains
            Console.WriteLine(frase.Contains("Jose") );
            Console.WriteLine(frase.Contains("Pedro"));

            //indexof
            var indiceDeJose = frase.IndexOf("Jose");
            var indiceDePedro = frase.IndexOf("Pedro");

            Console.WriteLine(indiceDeJose);
            Console.WriteLine(indiceDePedro);

            //operador +
            Console.WriteLine(nombre + ", " + frase);

            //ToLower
            Console.WriteLine(frase.ToLower());

            // ToUpper
            Console.WriteLine(frase.ToUpper());

            //Trim
            string ejemploTrim = "  Felipe  ";

            Console.WriteLine(ejemploTrim);
            Console.WriteLine(ejemploTrim.Trim());

            Console.WriteLine(nombre == ejemploTrim);
            Console.WriteLine(nombre == ejemploTrim.Trim());

            //Format
            string ejemploFormat = "Felicidades {0} en tu cumpleaños numero {1}! {0}";
            var resultadoFormat = string.Format(ejemploFormat, nombre, 50);
            Console.WriteLine(resultadoFormat);

            //Replace
            string ejemploReplace = "Felicidades @nombre en tu cumpleaños numero @edad!";
            var resultadoReplace = ejemploReplace.Replace("@nombre", nombre);
            resultadoReplace = ejemploReplace.Replace("@edad", "50");
            Console.WriteLine(resultadoReplace);

            //IsNullOrWhiteSpace

            string stringEspaciosEnBlanco = "   ";
            string stringNulo = null;
            Console.WriteLine(string.IsNullOrWhiteSpace(stringEspaciosEnBlanco));
            Console.WriteLine(string.IsNullOrWhiteSpace(stringNulo));
            Console.WriteLine(string.IsNullOrWhiteSpace(nombre));


            Console.Read();
        }
    }
}
