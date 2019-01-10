using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo_CSharp_3
{
    class Program
    {
        static void Main(string[] args)
        {
            var enviadorMensajeDependencia = FactoriaEnviadorMensaje.Factoria("SMS");
            var enviadorMensaje = new EnviadorMensaje(enviadorMensajeDependencia);
            enviadorMensaje.EnviarMensaje("Un mensaje");
            Console.Read();
        }
    }

    class FactoriaEnviadorMensaje
    {
        public static IEnviadorMensaje Factoria(string parametro)
        {
            if (parametro == "SMS")
            {
                return new EnviarMiniMensaje();
            }else if(parametro == "CORREO")
            {
                return new EnviarCorreo();
            }
            throw new ApplicationException();
        }
    }

    class EnviadorMensaje
    {
      
        public EnviadorMensaje()
        {
            _enviadorMensaje = new EnviarCorreo();
        }

        public EnviadorMensaje(IEnviadorMensaje enviadorMensaje)
        {
            _enviadorMensaje = enviadorMensaje;
        }

        public IEnviadorMensaje _enviadorMensaje;
        private IEnviadorMensaje enviadorMensajeDependencia;

        public void EnviarMensaje(string mensaje)
        {
            _enviadorMensaje.EnviarMensaje(mensaje);
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
