using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClaseNet_29
{
    public class Program
    {
        static void Main(string[] args)
        {
            var enviadorSMS = new EnviarCorreo();
            //  var enviadorMensaje = new EnviadorMensaje(enviadorSMS);  // por constructor
            //  enviadorMensaje.EnviarMensaje("Un mensaje");
            var enviadorMensaje = new EnviadorMensaje();
            enviadorMensaje._ienviadorMensaje = enviadorSMS;
              enviadorMensaje.EnviarMensaje("Un mensaje");
            Console.Read(); 

        }
    }

    public class EnviadorMensaje
    {

       public IEnviadorMensaje _ienviadorMensaje { get; set; }

        /*  private IEnviadorMensaje _enviadorMensaje;
          public EnviadorMensaje(IEnviadorMensaje enviadorMensaje)
          {
              _enviadorMensaje = enviadorMensaje;
          }  

          public void EnviarMensaje(string mensaje)
          {
              _enviadorMensaje.EnviarMensaje(mensaje);
          }
          */
        public void EnviarMensaje(string mensaje)
        {
            _ienviadorMensaje.EnviarMensaje(mensaje);
        }
    }

    public interface IEnviadorMensaje
    {
        void EnviarMensaje(string mensaje);
    }

    public class EnviarMiniMensaje : IEnviadorMensaje
    {
        public void EnviarMensaje(string mensaje)
        {
            Console.WriteLine("Enviando MiniMensaje.");  
        }
    }

    public class EnviarCorreo : IEnviadorMensaje
    {
        public void EnviarMensaje(string mensaje)
        {
            Console.WriteLine("Enviando Correo.");
        }
    }
}
