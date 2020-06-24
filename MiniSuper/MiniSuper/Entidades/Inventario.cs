using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MiniSuper.Entidades
{
    public class Inventario
    {
        public int idInventario { get; set; }
        public String nombreProducto { get; set; }
        public int idCategoria { get; set; }
        public int idProveedor { get; set; }
        public int existencias { get; set; }
        public Double costo { get; set; }
        public Double precioVenta { get; set; }
        public String estado { get; set; }
    }
}
