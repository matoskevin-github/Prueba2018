using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo_CSharp_17
{
    class Program
    {
        static void Main(string[] args)
        {
            string estatusOperacion = "K15";
            if (estatusOperacion == EstatusOperaciones._Exitoso)
            {

            }
            else if (estatusOperacion == EstatusOperaciones._ClienteNoEncontrado)
            {

            }
            else if (estatusOperacion == EstatusOperaciones._ErrorDelSistema)
            {

            }
            else
            {

            }
        }
    }

    static class EstatusOperaciones
    {
        public const string _Exitoso = "K120";
        public const string _ClienteNoEncontrado = "P4";
        public const string _ErrorDelSistema = "K15";
    }
}
