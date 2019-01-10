using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DemoLinq01
{
    public partial class frmFacturas : Form
    {
        private List<Factura> facturas;
        public frmFacturas()
        {
            InitializeComponent();
            ConsultarFacturas();
        }

        private void btnMostrarMensaje_Click(object sender, EventArgs e)
        {
            //   MessageBox.Show("Mensaje de prueba");
            dgvFacturas.DataSource = facturas.ToList();  
        }

        private void frmFacturas_Load(object sender, EventArgs e)
        {

        }

        private void ConsultarFacturas()
        {
            facturas = new List<Factura> {
                new Factura
                {
                    NroFactura = 1,
                    Cliente = "Pedro Perez",
                    Empleado = "Carlos Arango",
                    Fecha = DateTime.Now,
                    SubTotal = 1000000,
                    Iva = 190000,
                    Descuento = 0,
                    Total = 1190000,
                    detalle = new List<DetalleFactura> {
                    new DetalleFactura {
                        idDetalle = 1,
                        NroFactura = 1,
                        Producto = "Televisor",
                        Cantidad = 1,
                        ValorUnitario = 1000000

                }
                }
                },
                new Factura {
                    NroFactura = 2,
                    Cliente = "Pedro Perez",
                    Empleado = "Carlos Arango",
                    Fecha = new DateTime(2018,01,01,10,36,0),
                    SubTotal = 500000,
                    Iva = 80000,
                    Descuento = 10000,
                    Total = 5570000,
                    detalle = new List<DetalleFactura> {
                    new DetalleFactura {
                        idDetalle = 3,
                        NroFactura = 2,
                        Producto = "Licuadora",
                        Cantidad = 1,
                        ValorUnitario = 280000

                }
                }
                }
            };
            //  throw new NotImplementedException();
        }
    }
}
