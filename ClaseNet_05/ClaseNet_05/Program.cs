using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClaseNet_05
{
    class Program
    {
        static void Main(string[] args)
        {
            Persona p1 = new Persona();
            p1.Nombre = "Lorena";
            p1.Edad = 35;
            p1.Direccion = "Avenida Siempre viva";
            p1.MostrarDatosConsola();

            Persona p2 = new Persona();
            p2.Nombre = "Mario";
            p2.Edad = 35;
            p2.Direccion = "Av. Winston Churchill";
            p2.MostrarDatosConsola();
            Console.Read();  

        }
    }

    class Persona
    {
        public string Nombre;
        public int Edad;
        public string Direccion;

        public void MostrarDatosConsola()
        {
            string strOutPut = "El nombre es {0}, la edad es {1} y su dirección es {2}";
            strOutPut = string.Format(strOutPut,Nombre,Edad,Direccion);
            Console.WriteLine(strOutPut);

        }

    }
}
