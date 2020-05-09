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
    public class MDetallesCompra
    {
        public void RegistrarDetalleCompra(DetallesCompra dc)
        {
            IDbConnection cn = Conexion.Conexion.Conectar();
            DynamicParameters paramentros = new DynamicParameters();
            paramentros.Add("@idCompra", dc.idCompra, DbType.Int32);
            paramentros.Add("@idInventario", dc.idInventario, DbType.Int32);
            paramentros.Add("@cantidad", dc.cantidad, DbType.Int32);
            paramentros.Add("@precio", dc.precio, DbType.Double);
            cn.Open();
            cn.Execute("sp_InsertarDetalleCompra", paramentros, commandType: CommandType.StoredProcedure);
            cn.Close();
        }

        public void EliminarDetalleCompra(DetallesCompra dc)
        {
            IDbConnection cn = Conexion.Conexion.Conectar();
            DynamicParameters paramentros = new DynamicParameters();
            paramentros.Add("@id", dc.idDetalleCompra, DbType.Int32);
            cn.Open();
            cn.Execute("sp_EliminarDetalleCompra", paramentros, commandType: CommandType.StoredProcedure);
            cn.Close();
        }

        public List<DetallesCompra> ListadoDetallesCompra()
        {
            List<DetallesCompra> lista = new List<DetallesCompra>();
            IDbConnection cn = Conexion.Conexion.Conectar();
            cn.Open();
            lista = cn.Query<DetallesCompra>("sp_ConsultarDetallesCompra", commandType: CommandType.StoredProcedure).ToList();
            cn.Close();
            return lista;
        }
    }
}
