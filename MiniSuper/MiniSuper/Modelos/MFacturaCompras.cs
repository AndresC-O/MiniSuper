using MiniSuper.Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Dapper;
using System.Data;

namespace MiniSuper.Modelos
{
    public class MFacturaCompras
    {
        public void RegistrarFacturaCompra(FacturasCompras fc)
        {
            IDbConnection cn = Conexion.Conexion.Conectar();
            DynamicParameters parametros = new DynamicParameters();
            parametros.Add("@idProducto", fc.idProducto, DbType.Int32);
            parametros.Add("@idProveedor", fc.idProveedor, DbType.Int32);
            parametros.Add("@cantidad", fc.cantidad, DbType.Int32);
            parametros.Add("@fecha", fc.Fecha, DbType.String);
            cn.Open();
            cn.Execute("sp_InsertarFactCompras", parametros, commandType: CommandType.StoredProcedure);
            cn.Close();
        }

        public void ActualizarFaturaCompra(FacturasCompras fc)
        {
            IDbConnection cn = Conexion.Conexion.Conectar();
            DynamicParameters parametros = new DynamicParameters();
            parametros.Add("@id", fc.idFacturaCompra, DbType.Int32);
            parametros.Add("@nuevoIdProd", fc.idProducto, DbType.Int32);
            parametros.Add("@nuevoIdProveedor", fc.idProveedor, DbType.Int32);
            parametros.Add("@cantidad", fc.cantidad, DbType.Int32);
            parametros.Add("@fecha", fc.Fecha, DbType.String);
            cn.Open();
            cn.Execute("sp_ModificarFactsCompras", parametros, commandType: CommandType.StoredProcedure);
            cn.Close();
        }

        public void EliminarFacturaCompra(FacturasCompras fc)
        {
            IDbConnection cn = Conexion.Conexion.Conectar();
            DynamicParameters parametros = new DynamicParameters();
            parametros.Add("@id", fc.idFacturaCompra, DbType.Int32);
            cn.Open();
            cn.Execute("sp_EliminarFactCompra", parametros, commandType: CommandType.StoredProcedure);
            cn.Close();
        }

        public List<FacturasCompras> ListadoFactsCompras()
        {
            List<FacturasCompras> lista = new List<FacturasCompras>();
            IDbConnection cn = Conexion.Conexion.Conectar();
            cn.Open();
            lista = cn.Query<FacturasCompras>("sp_ConsultarFactsCompras", commandType: CommandType.StoredProcedure).ToList();
            cn.Close();
            return lista;
        }
    }
}
