using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo_CSharp_35
{
    class Program
    {
        static void Main(string[] args)
        {
            var enviadorSMS = new EnviarCorreo();
            // var enviadorMensaje = new EnviadorMensaje(enviadorSMS);
            var enviadorMensaje = new EnviadorMensaje();
            enviadorMensaje.ImplementacionEnviadorMensaje = enviadorSMS;
            enviadorMensaje.EnviarMensaje("Un Mensaje");
            Console.Read();
        }
    }

    class EnviadorMensaje
    {
        /*
        public EnviadorMensaje(IEnviadorMensaje enviadorMensaje)
        {
            _enviadorMensaje = enviadorMensaje;
        }
        */

        public IEnviadorMensaje ImplementacionEnviadorMensaje { get; set; }
        public IEnviadorMensaje _enviadorMensaje;
      
        public void EnviarMensaje(string mensaje)
        {
            ImplementacionEnviadorMensaje.EnviarMensaje(mensaje);
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
    }

    class EnviarCorreo : IEnviadorMensaje
    {
        public void EnviarMensaje(string mensaje)
        {
            Console.WriteLine("Enviando correo");
        }
    }
}
