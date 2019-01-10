using AppPOO.Clases;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppPOO
{
    class Program
    {
        static void Main(string[] args)
        {
            Persona oPersona = new Persona();
           
            oPersona.Nombre = "Victor Matos";
            oPersona.Cedula = 328657;

            Vehiculo oVehiculo = new Vehiculo();
            oVehiculo.Placa = "ASD-85AT";
            oVehiculo.Marca = "TOYOTA";
          /*  string saluda = oPersona.Saludar("Victor Matos");
            int velo = oVehiculo.ObtenerVelocidad();*/
            Console.WriteLine(oPersona.Nombre);
            Console.WriteLine(oPersona.Cedula );
            Console.WriteLine(oPersona.Saludar("Victor Matos"));
            Console.WriteLine(oVehiculo.Placa);
            Console.WriteLine(oVehiculo.Marca );
            Console.WriteLine("KM/HR => "+oVehiculo.ObtenerVelocidad());
            Console.Read(); 
        }
    }
}
