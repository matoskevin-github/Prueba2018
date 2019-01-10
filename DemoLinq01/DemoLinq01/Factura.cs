using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DemoLinq01
{
    public class Factura
    {
        public int NroFactura { get; set; }
        public string Cliente { get; set; }
        public DateTime Fecha { get; set; }
        public string Empleado { get; set; }
        public double SubTotal { get; set; }
        public double Descuento{ get; set; }
        public double Iva { get; set; }
        public double Total { get; set; }
        public List<DetalleFactura > detalle { get; set; }
    }
}
