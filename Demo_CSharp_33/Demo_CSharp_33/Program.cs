using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo_CSharp_33
{
    class Program
    {
        static void Main(string[] args)
        {
            var miniMensaje = new EnviarMiniMensaje();
            var enviarCorreo = new EnviarCorreo();
            Enviar(miniMensaje, "Prueba");
            Enviar(enviarCorreo, "Prueba2");

            Console.Read();
        }

        private static void Enviar(IEnviadorMensaje mensajero, string mensaje)
        {
            mensajero.EnviarMensaje(mensaje);
        }
    }

    interface IEnviadorMensaje
    {
        void EnviarMensaje(string mensaje);
    }

    class EnviarMiniMensaje : IEnviadorMensaje
    {
        public void EnviarMensaje(string mensaje)
        {
            Console.WriteLine("Enviando minimensaje");
        }

        public string CualquierMetodo()
        {
            return "Lo que sea";
        }
    }

    class EnviarCorreo : IEnviadorMensaje
    {
        public void EnviarMensaje(string mensaje)
        {
            Console.WriteLine("Enviando Correo");
        }
    }
}
