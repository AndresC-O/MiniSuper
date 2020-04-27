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
    public class MFacturaConsumidoresFinales
    {
        public void RegistrarFacturaConsFinal(FacturasConsumidoresFinales fcf)
        {
            IDbConnection cn = Conexion.Conexion.Conectar();
            DynamicParameters parametros = new DynamicParameters();
            parametros.Add("@idCliente", fcf.idCliente, DbType.Int32);
            parametros.Add("@numeroFactura", fcf.numeroFactura, DbType.String);
            parametros.Add("@idProducto", fcf.idProducto, DbType.Int64);
            parametros.Add("@fecha", fcf.fecha, DbType.String);
            parametros.Add("@cantidad", fcf.cantidad, DbType.Int64);
            cn.Open();
            cn.Execute("sp_InsertarFactConsFinal", parametros, commandType: CommandType.StoredProcedure);
            cn.Close();
        }

        public void ActualizarFacturaConsFinal(FacturasConsumidoresFinales fcf)
        {
            IDbConnection cn = Conexion.Conexion.Conectar();
            DynamicParameters parametros = new DynamicParameters();
            parametros.Add("@id", fcf.idFacturaCF, DbType.Int32);
            parametros.Add("@nuevoidCLiente", fcf.idCliente, DbType.Int32);
            parametros.Add("@newNumeroFact", fcf.numeroFactura, DbType.String);
            parametros.Add("@nuevoIdProd", fcf.idProducto, DbType.Int64);
            parametros.Add("@fecha", fcf.fecha, DbType.String);
            parametros.Add("@cantidad", fcf.cantidad, DbType.Int64);
            cn.Open();
            cn.Execute("sp_ModificarFactsConsFinal", parametros, commandType: CommandType.StoredProcedure);
            cn.Close();
        }

        public void EliminarFacturaConsFinal(FacturasConsumidoresFinales fcf)
        {
            IDbConnection cn = Conexion.Conexion.Conectar();
            DynamicParameters parametros = new DynamicParameters();
            parametros.Add("@id", fcf.idFacturaCF, DbType.Int32);
            cn.Open();
            cn.Execute("sp_EliminarFactConsFinal", parametros, commandType: CommandType.StoredProcedure);
            cn.Close();
        }

        public List<FacturasConsumidoresFinales> ListadoFacturasConsFinal()
        {
            List<FacturasConsumidoresFinales> lista = new List<FacturasConsumidoresFinales>();
            IDbConnection cn = Conexion.Conexion.Conectar();
            cn.Open();
            lista = cn.Query<FacturasConsumidoresFinales>("sp_ConsultarFactsConsFinales", commandType: CommandType.StoredProcedure).ToList();
            cn.Close();
            return lista;
        }
    }
}
