using MiniSuper.Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using Dapper;
using System.Text;
using System.Threading.Tasks;
using System.Data;

namespace MiniSuper.Modelos
{
    public class MCompras
    {
        public void RegistrarCompra(Compras c)
        {
            IDbConnection cn = Conexion.Conexion.Conectar();
            DynamicParameters paramentros = new DynamicParameters();
            paramentros.Add("@idEmpleado", c.idEmpleado, DbType.Int32);
            paramentros.Add("@idProveedor", c.idProveedor, DbType.Int32);
            paramentros.Add("@totalCompra", c.TotalCompra, DbType.Double);
            paramentros.Add("@fecha", c.Fecha, DbType.String);
            cn.Open();
            cn.Execute("sp_InsertarCompra", paramentros, commandType: CommandType.StoredProcedure);
            cn.Close();
        }

        public void EliminarCompra(Compras c)
        {
            IDbConnection cn = Conexion.Conexion.Conectar();
            DynamicParameters paramentros = new DynamicParameters();
            paramentros.Add("@id", c.idCompra, DbType.Int32);
            cn.Open();
            cn.Execute("sp_EliminarCompra", paramentros, commandType: CommandType.StoredProcedure);
            cn.Close();
        }

        public List<Compras> ListadoCompras()
        {
            List<Compras> lista = new List<Compras>();
            IDbConnection cn = Conexion.Conexion.Conectar();
            cn.Open();
            lista = cn.Query<Compras>("sp_ConsultarCompras", commandType: CommandType.StoredProcedure).ToList();
            cn.Close();
            return lista;
        }
    }
}
