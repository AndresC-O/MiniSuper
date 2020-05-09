using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MiniSuper.Entidades
{
    public class Compras
    {
        public int idCompra { get; set; }
        public int idEmpleado { get; set; }
        public int idProveedor { get; set; }
        public Double TotalCompra { get; set; }
        public String Fecha { get; set; }
    }
}
