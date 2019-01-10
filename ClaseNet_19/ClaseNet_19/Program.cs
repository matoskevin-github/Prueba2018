using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClaseNet_19
{
    enum EstatusOperacion
    {
        EXITOSO = 1,
        CLIENTE_NO_ENCONTRADO = 2,
        ERROR_DE_SISTEMA = 5,
    }

    class Program
    {
        static void Main(string[] args)
        {
            int estatusOperacion = 5;
            if (estatusOperacion == (int)EstatusOperacion.EXITOSO )
            {

            }

            else if (estatusOperacion == (int)EstatusOperacion.CLIENTE_NO_ENCONTRADO )
            {

            }
            else if (estatusOperacion == (int)EstatusOperacion.ERROR_DE_SISTEMA )
            {

            }
        }
    }
}
