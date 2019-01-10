using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo_CSharp_05
{
    public class Factura
    {
        public int Id { get; set; }
        public DateTime  Creacion { get; set; }
        public decimal  Total { get; set; }
        public string Cliente { get; set; }
        public string Facturador { get; set; }
        //...Otras Variables
    }
}
