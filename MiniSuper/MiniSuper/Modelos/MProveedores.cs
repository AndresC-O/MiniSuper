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
    public class MProveedores
    {
        public void RegistrarProveedor(Proveedores pr)
        {
            IDbConnection cn = Conexion.Conexion.Conectar();
            DynamicParameters parametros = new DynamicParameters();
            parametros.Add("@nombreProveedor", pr.nombreProveedor, DbType.String);
            parametros.Add("@direccion", pr.direccion, DbType.String);
            parametros.Add("@telefono", pr.telefono, DbType.String);
            cn.Open();
            cn.Execute("sp_InsertarProveedor", parametros, commandType: CommandType.StoredProcedure);
            cn.Close();
        }

        public void ActualizarProveedor(Proveedores pr)
        {
            IDbConnection cn = Conexion.Conexion.Conectar();
            DynamicParameters parametros = new DynamicParameters();
            parametros.Add("@id", pr.idProveedor, DbType.Int32);
            parametros.Add("@newNombreProveedor", pr.nombreProveedor, DbType.String);
            parametros.Add("@direccion", pr.direccion, DbType.String);
            parametros.Add("@telefono", pr.telefono, DbType.String);
            cn.Open();
            cn.Execute("sp_ModificarProveedor", parametros, commandType: CommandType.StoredProcedure);
            cn.Close();
        }

        public void EliminarProveedor(Proveedores pr)
        {
            IDbConnection cn = Conexion.Conexion.Conectar();
            DynamicParameters parametros = new DynamicParameters();
            parametros.Add("@id", pr.idProveedor, DbType.Int32);
            cn.Open();
            cn.Execute("sp_EliminarProveedor", parametros, commandType: CommandType.StoredProcedure);
            cn.Close();
        }

        public List<Proveedores> ListadoProveedores()
        {
            List<Proveedores> lista = new List<Proveedores>();
            IDbConnection cn = Conexion.Conexion.Conectar();
            cn.Open();
            lista = cn.Query<Proveedores>("sp_ConsultarProveedores", commandType: CommandType.StoredProcedure).ToList();
            cn.Close();
            return lista;
        }
    }
}
