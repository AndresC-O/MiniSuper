using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MiniSuper.Entidades
{
    public class FacturasConsumidoresFinales
    {
        public int idFacturaCF { get; set; }
        public int idCliente { get; set; }
        public String numeroFactura { get; set; }
        public int idProducto { get; set; }
        public String fecha { get; set; }
        public int cantidad { get; set; }
        public Double Total { get; set; }
    }
}
