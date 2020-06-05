using Dapper;
using MiniSuper.Entidades;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MiniSuper.Modelos
{
    public class MDetallesVenta
    {
        public void RegistrarDetalleVenta(DetallesVenta dv)
        {
            IDbConnection cn = Conexion.Conexion.Conectar();
            DynamicParameters paramentros = new DynamicParameters();
            paramentros.Add("@idVenta", dv.idVenta, DbType.Int32);
            paramentros.Add("@idInventario", dv.idInventario, DbType.Int32);
            paramentros.Add("@cantidad", dv.cantidad, DbType.Int32);
            paramentros.Add("@precio", dv.precio, DbType.Double);
            paramentros.Add("@total", dv.total, DbType.Double);
            cn.Open();
            cn.Execute("sp_InsertarDetalleVenta", paramentros, commandType: CommandType.StoredProcedure);
            cn.Close();
        }

        public void EliminarDetalleVenta(DetallesVenta dv)
        {
            IDbConnection cn = Conexion.Conexion.Conectar();
            DynamicParameters paramentros = new DynamicParameters();
            paramentros.Add("@id", dv.idDetalleVenta, DbType.Int32);
            cn.Open();
            cn.Execute("sp_EliminarDetalleVenta", paramentros, commandType: CommandType.StoredProcedure);
            cn.Close();
        }

        public List<DetallesVenta> ListadoDetallesVenta()
        {
            List<DetallesVenta> lista = new List<DetallesVenta>();
            IDbConnection cn = Conexion.Conexion.Conectar();
            cn.Open();
            lista = cn.Query<DetallesVenta>("sp_ConsultarDetallesVenta", commandType: CommandType.StoredProcedure).ToList();
            cn.Close();
            return lista;
        }
    }
}
