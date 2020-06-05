using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MiniSuper.Entidades
{
    public class DetallesVenta
    {
        public int idDetalleVenta { get; set; }
        public int idVenta { get; set; }
        public int idInventario { get; set; }
        public int cantidad { get; set; }
        public Double precio { get; set; }
        public Double total { get; set; }
    }
}
