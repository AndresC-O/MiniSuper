using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MiniSuper.Entidades
{
    public class Ventas
    {
        public int idVenta { get; set; }
        public int idEmpleado { get; set; }
        public int idCliente { get; set; }
        public int idDocumento { get; set; }
        public Double totalVenta { get; set; }
        public String fecha { get; set; }
    }
}
