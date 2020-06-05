using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MiniSuper.Entidades
{
    public class DetallesCompra
    {
        public int idDetalleCompra { get; set; }
        public int idCompra { get; set; }
        public int idInventario { get; set; }
        public int cantidad { get; set; }
        public Double precio { get; set; }
        public Double total { get; set; }
    }
}
