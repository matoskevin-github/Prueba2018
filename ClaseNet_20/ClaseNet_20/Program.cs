using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClaseNet_20
{
    class Program
    {


        static void Main(string[] args)
        {
            string estatusOperacion = "K15";
            if (estatusOperacion == EstatusOperaciones._EXITOSO)
            {
                //....
            }
            else if (estatusOperacion == EstatusOperaciones._CLIENTE_NO_ENCONTRADO)
            {
                //....
            }
            else if (estatusOperacion == EstatusOperaciones._ERROR_DE_SISTEMA)
            {
                //....
            }
            Console.Read();
        }


    }

    public static class EstatusOperaciones
    {
        public const string _EXITOSO = "K120";
        public const string _CLIENTE_NO_ENCONTRADO = "P4";
        public const string _ERROR_DE_SISTEMA = "K15";
    }
}
