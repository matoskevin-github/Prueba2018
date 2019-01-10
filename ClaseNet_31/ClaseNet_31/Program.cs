using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;
using System.Xml.Serialization;

namespace ClaseNet_31
{
    class Program
    {
        static void Main(string[] args)
        {
            var persona1 = new Persona()
            {
                Nombre = "Felipe"
            };
            var xml_persona1 = Serializar<Persona>(persona1);

            var persona2 = new Persona()
            {
                Nombre = "Carla"
            };
            var xml_persona2 = Serializar<Persona>(persona2);

            var empresa1 = new Empresa() { Direccion = "Av. Peru 123" };
            var xml_empresa1 = Serializar<Empresa>(empresa1);
        }

        private static string Serializar<T>(T valor)
        {
            XmlSerializer serializador = new XmlSerializer(typeof(T));

            using (var escritorString = new StringWriter())
            {
                using (var escritor = XmlWriter.Create(escritorString))
                {
                    serializador.Serialize(escritor, valor);
                    return escritorString.ToString();
                }
            }
        }
    }

    class Persona
    {
        public string Nombre { get; set; }
    }

    class Empresa
    {
        public string Direccion { get; set; }
    }
}
