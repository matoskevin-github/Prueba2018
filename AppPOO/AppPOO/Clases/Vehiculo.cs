using System;

namespace AppPOO.Clases
{
    public class Vehiculo
    {
        public string Placa { get; set; }
        public string Marca { get; set; }

        internal int ObtenerVelocidad()
        {
            return 250;
        }
    }
}
