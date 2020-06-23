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
    public class MVentas
    {
        public void RegistrarVenta(Ventas v)
        {
            IDbConnection cn = Conexion.Conexion.Conectar();
            DynamicParameters paramentros = new DynamicParameters();
            paramentros.Add("@idEmpleado", v.idEmpleado, DbType.Int32);
            paramentros.Add("@idCliente", v.idCliente, DbType.Int32);
            paramentros.Add("@idDocumento", v.idDocumento, DbType.Int32);
            paramentros.Add("@totalVenta", v.totalVenta, DbType.Double);
            paramentros.Add("@fecha", v.fecha, DbType.String);
            cn.Open();
            cn.Execute("sp_InsertarVenta", paramentros, commandType: CommandType.StoredProcedure);
            cn.Close();
        }

        public void EliminarVenta(Ventas v)
        {
            IDbConnection cn = Conexion.Conexion.Conectar();
            DynamicParameters paramentros = new DynamicParameters();
            paramentros.Add("@id", v.idVenta, DbType.Int32);
            cn.Open();
            cn.Execute("sp_EliminarVenta", paramentros, commandType: CommandType.StoredProcedure);
            cn.Close();
        }

        public List<Ventas> ListadoVentas()
        {
            List<Ventas> lista = new List<Ventas>();
            IDbConnection cn = Conexion.Conexion.Conectar();
            cn.Open();
            lista = cn.Query<Ventas>("sp_ConsultarVentas", commandType: CommandType.StoredProcedure).ToList();
            cn.Close();
            return lista;
        }

        public List<Ventas> RetornoId()
        {
            List<Ventas> lista = new List<Ventas>();
            IDbConnection cn = Conexion.Conexion.Conectar();
            cn.Open();
            lista = cn.Query<Ventas>("RotornoID", commandType: CommandType.StoredProcedure).ToList();
            cn.Close();
            return lista;
        }
    }
}
