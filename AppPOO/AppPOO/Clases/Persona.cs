using System;

namespace AppPOO.Clases
{
    public class Persona
    {
        public string Nombre { get; set; }
        public int Cedula { get; set; }

        internal string Saludar(string valor)
        {
            return "Hola " + valor; 
        }
    }
}
