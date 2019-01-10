using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo_CSharp_29
{
    class Program
    {
        static void Main(string[] args)
        {
            var e1 = new Empresa();
            e1._NombreLegal = "Primera Empresa";
            e1._Direccion = "Primera Direccion";

            var e2 = new Empresa();
            e2._NombreLegal = "Segunda Empresa";
            e2._Direccion = "Segunda Direccion";

            e1.metodo(e2);
            e2.metodo(e1);
            e1.metodo(e1);

            Console.Read();
        }
    }

    class Empresa
    {
        public string _NombreLegal;
        public string _Direccion;

        public void metodo(Empresa emp)
        {
            var this_NombreLegal = this._NombreLegal;
            var this_Direccion = this._Direccion;
            var miDireccion = _Direccion;
            var miNombreLegal = _NombreLegal;
            var emp_NombreLegal = emp._NombreLegal;
            var emp_Direccion = emp._Direccion;
        }
    }
}
