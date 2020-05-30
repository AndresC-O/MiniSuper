using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Sql;
using System.Data.SqlClient;
using System.Data;

namespace MiniSuper.Conexion
{
    public class Conexion
    {
        //Método que nos servirá para conectarnos a nuestro servidor donde se encuentra la base de datos.
        public static IDbConnection Conectar()
        {
            //String cadena = "Data Source=.;Initial Catalog=MiniSuper;Integrated Security=True";
            String cadena = "Data Source=CLARIEL\\SQLEXPRESS;Initial Catalog=MiniSuper;Integrated Security=True";
            SqlConnection cn = new SqlConnection(cadena);
            IDbConnection conexion = cn;
            return conexion;
        }
    }
}
