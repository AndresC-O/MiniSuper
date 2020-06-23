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
    public class MInventario
    {
        public void RegistrarInventario(Inventario i)
        {
            IDbConnection cn = Conexion.Conexion.Conectar();
            DynamicParameters parametros = new DynamicParameters();
            parametros.Add("@nombreProducto", i.nombreProducto, DbType.String);
            parametros.Add("@idCategoria", i.idCategoria, DbType.Int32);
            parametros.Add("@idProveedor", i.idProveedor, DbType.Int32);
            parametros.Add("@existencias", i.existencias, DbType.Int32);
            parametros.Add("@costo", i.costo, DbType.Double);
            parametros.Add("@precioVenta", i.precioVenta, DbType.Double);
            cn.Open();
            cn.Execute("sp_InsertarInventario", parametros, commandType: CommandType.StoredProcedure);
            cn.Close();
        }

        public void ActualizarInventario(Inventario i)
        {
            IDbConnection cn = Conexion.Conexion.Conectar();
            DynamicParameters parametros = new DynamicParameters();
            parametros.Add("@id", i.idInventario, DbType.Int32);
            parametros.Add("@nuevoNombreProd", i.nombreProducto, DbType.String);
            parametros.Add("@idCategoria", i.idCategoria, DbType.Int32);
            parametros.Add("@idProveedor", i.idProveedor, DbType.Int32);
            parametros.Add("@existencias", i.existencias, DbType.Int32);
            parametros.Add("@costo", i.costo, DbType.Double);
            parametros.Add("@precioVenta", i.precioVenta, DbType.Double);
            cn.Open();
            cn.Execute("sp_ModificarInventario", parametros, commandType: CommandType.StoredProcedure);
            cn.Close();
        }

        public void EliminarInventario(Inventario i)
        {
            IDbConnection cn = Conexion.Conexion.Conectar();
            DynamicParameters parametros = new DynamicParameters();
            parametros.Add("@id", i.idInventario, DbType.Int32);
            cn.Open();
            cn.Execute("sp_EliminarInventario", parametros, commandType: CommandType.StoredProcedure);
            cn.Close();
        }

        public List<Inventario> ListadoInventarios()
        {
            List<Inventario> lista = new List<Inventario>();
            IDbConnection cn = Conexion.Conexion.Conectar();
            cn.Open();
            lista = cn.Query<Inventario>("sp_ConsultarInventario", commandType: CommandType.StoredProcedure).ToList();
            cn.Close();
            return lista;
        }

        public List<Inventario> ListadoInventariosxPro(int pro)
        {
            List<Inventario> lista = new List<Inventario>();
            IDbConnection cn = Conexion.Conexion.Conectar();
            DynamicParameters parametros = new DynamicParameters();
            parametros.Add("@idProveedor", DbType.Int32);
            cn.Open();
            lista = cn.Query<Inventario>("InvenXProveedor", parametros, commandType: CommandType.StoredProcedure).ToList();
            cn.Close();
            return lista;
        }
    }
}
