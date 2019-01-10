using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DemoLinq01
{
    public class DetalleFactura
    {
        public int idDetalle { get; set; }
        public int NroFactura { get; set; }
        public string Producto { get; set; }
        public int Cantidad { get; set; }
        public double ValorUnitario { get; set; } 
    }
}
