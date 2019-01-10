using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClaseNet_10
{
    class Program
    {
        static void Main(string[] args)
        {
            DateTime fecha = new DateTime(2014, 10, 23);
            DateTime fechaHora = new DateTime(2005, 4, 23, 9, 30, 45);

            Console.WriteLine(fecha.ToString());
            Console.WriteLine(fecha.ToString("MM/dd/yyyy"));
            Console.WriteLine(fecha.ToString("dd-MM-yyyy"));
            Console.WriteLine(fechaHora.ToString("dd-MM-yyyy hh:mm:ss"));

            Console.WriteLine(fecha.AddDays(45).ToString());
            Console.WriteLine(fechaHora.DayOfWeek);
            Console.WriteLine(fechaHora.Date);

            Console.WriteLine(fecha.Subtract(fechaHora).Days);  


            Console.Read();
        }
    }
}
