using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Dapper;
using System.Data;
using MiniSuper.Entidades;

namespace MiniSuper.Modelos
{
    public class MSucursales
    {
        public void RegistrarSucursal(Sucursales s)
        {
            IDbConnection cn = Conexion.Conexion.Conectar();
            DynamicParameters parametros = new DynamicParameters();
            parametros.Add("@nombreSucursal", s.nombreSucursal, DbType.String);
            parametros.Add("@ubicacion", s.ubicacion, DbType.String);
            cn.Open();
            cn.Execute("sp_InsertarSucursal", parametros, commandType: CommandType.StoredProcedure);
            cn.Close();
        }

        public void ActualizarSucursal(Sucursales s)
        {
            IDbConnection cn = Conexion.Conexion.Conectar();
            DynamicParameters parametros = new DynamicParameters();
            parametros.Add("@id", s.idSucursal, DbType.Int32);
            parametros.Add("@newNombreSucursal", s.nombreSucursal, DbType.String);
            parametros.Add("@ubicacion", s.ubicacion, DbType.String);
            cn.Open();
            cn.Execute("sp_ModificarSucursal", parametros, commandType: CommandType.StoredProcedure);
            cn.Close();
        }

        public void EliminarSucursal(Sucursales s)
        {
            IDbConnection cn = Conexion.Conexion.Conectar();
            DynamicParameters parametros = new DynamicParameters();
            parametros.Add("@id", s.idSucursal, DbType.Int32);
            cn.Open();
            cn.Execute("sp_EliminarSucursal", parametros, commandType: CommandType.StoredProcedure);
            cn.Close();
        }

        public List<Sucursales> ListadoSucursales()
        {
            List<Sucursales> lista = new List<Sucursales>();
            IDbConnection cn = Conexion.Conexion.Conectar();
            cn.Open();
            lista = cn.Query<Sucursales>("sp_ConsultarSucursal", commandType: CommandType.StoredProcedure).ToList();
            cn.Close();
            return lista;
        }
    }
}
