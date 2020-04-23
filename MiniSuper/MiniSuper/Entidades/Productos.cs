using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MiniSuper.Entidades
{
    public class Productos
    {
        public int idProducto { get; set; }
        public String nombreProducto { get; set; }
        public int idCategoria { get; set; }
        public int idProveedor { get; set; }
    }
}
