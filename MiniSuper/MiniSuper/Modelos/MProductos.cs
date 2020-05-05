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
    public class MProductos
    {
        public void RegistrarProducto(Productos p)
        {
            IDbConnection cn = Conexion.Conexion.Conectar();
            DynamicParameters parametros = new DynamicParameters();
            parametros.Add("@nombreProducto", p.nombreProducto, DbType.String);
            parametros.Add("@idCategoria", p.idCategoria, DbType.Int32);
            parametros.Add("@idProveedor", p.idProveedor, DbType.Int32);
            cn.Open();
            cn.Execute("sp_InsertarProductos", parametros, commandType: CommandType.StoredProcedure);
            cn.Close();
        }

        public void ActualizarProducto(Productos p)
        {
            IDbConnection cn = Conexion.Conexion.Conectar();
            DynamicParameters parametros = new DynamicParameters();
            parametros.Add("@id", p.idProducto, DbType.Int32);
            parametros.Add("@nuevoNombre", p.nombreProducto, DbType.String);
            parametros.Add("@idCategoria", p.idCategoria, DbType.Int32);
            parametros.Add("@idProveedor", p.idProveedor, DbType.Int32);
            cn.Open();
            cn.Execute("sp_ModificarProducto", parametros, commandType: CommandType.StoredProcedure);
            cn.Close();
        }

        public void EliminarProducto(Productos p)
        {
            IDbConnection cn = Conexion.Conexion.Conectar();
            DynamicParameters parametros = new DynamicParameters();
            parametros.Add("@id", p.idProducto, DbType.Int32);
            cn.Open();
            cn.Execute("sp_EliminarProducto", parametros, commandType: CommandType.StoredProcedure);
            cn.Close();
        }

        public List<Productos> ListadoProductos()
        {
            List<Productos> lista = new List<Productos>();
            IDbConnection cn = Conexion.Conexion.Conectar();
            cn.Open();
            lista = cn.Query<Productos>("sp_ConsultarProductos", commandType: CommandType.StoredProcedure).ToList();
            cn.Close();
            return lista;
        }
    }
}
