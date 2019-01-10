using System.IO;
using System.Xml;
using System.Xml.Serialization;

namespace Demo_CSharp_38
{
    public class Program
    {
        static void Main(string[] args)
        {
            var persona1 = new Persona() { Nombre = "Felipe" };
            var xml_persona1 = Serializar<Persona>(persona1);

            var persona2 = new Persona() { Nombre = "Carla" };
            var xml_persona2 = Serializar<Persona>(persona2);

            var empresa1 = new Empresa() { Direccion = ""};
            var xml_empresa1 = Serializar<Empresa>(empresa1);


        }

        public static string Serializar<T>(T obj)
        {
            var serializador = new XmlSerializer(typeof(T));
            using (var escritorString = new StringWriter())
            {
                using (var escritor = XmlWriter.Create(escritorString))
                {
                    serializador.Serialize(escritor, obj);
                    return escritorString.ToString();
                }
            }
        }
    }

    public class Persona
    {
        public string  Nombre { get; set; }
    }

    public class Empresa
    {
        public string Direccion { get; set; }
    }
}
