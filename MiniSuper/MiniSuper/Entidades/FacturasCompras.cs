using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MiniSuper.Entidades
{
    public class FacturasCompras
    {
        public int idFacturaCompra { get; set; }
        public int idProducto { get; set; }
        public int idProveedor { get; set; }
        public int cantidad { get; set; }
        public String Fecha { get; set; }
        public Double total { get; set; }
    }
}
