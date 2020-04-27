using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MiniSuper.Entidades
{
    public class Empleados
    {
        public int idEmpleado { get; set; }
        public String nombresEmpleado { get; set; }
        public String apellidosEmpleado { get; set; }
        public int idCargo { get; set; }
        public int idSucursal { get; set; }
        public String dui { get; set; }
        public String usuario { get; set; }
        public String contrasenia { get; set; }
        public String codigoEmpleado { get; set; }
    }
}
