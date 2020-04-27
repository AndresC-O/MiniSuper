using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Threading.Tasks;
using Dapper;
using MiniSuper.Entidades;

namespace MiniSuper.Modelos
{
    public class MCategorias
    {
        public void RegistrarCategoria(Categorias ca)
        {
            IDbConnection cn = Conexion.Conexion.Conectar();
            DynamicParameters paramentros = new DynamicParameters();
            paramentros.Add("@nombreCategoria", ca.nombreCategoria, DbType.String);
            cn.Open();
            cn.Execute("sp_InsertarCategoria", paramentros, commandType: CommandType.StoredProcedure);
            cn.Close();
        }

        public void ActualizarCategoria(Categorias ca)
        {
            IDbConnection cn = Conexion.Conexion.Conectar();
            DynamicParameters parametros = new DynamicParameters();
            parametros.Add("@id", ca.idCategoria, DbType.Int32);
            parametros.Add("@nuevoNombre", ca.nombreCategoria, DbType.String);
            cn.Open();
            cn.Execute("sp_ModificarCategoria", parametros, commandType: CommandType.StoredProcedure);
            cn.Close();
        }

        public void EliminarCategoria(Categorias ca)
        {
            IDbConnection cn = Conexion.Conexion.Conectar();
            DynamicParameters parametros = new DynamicParameters();
            parametros.Add("@id", ca.idCategoria, DbType.Int32);
            cn.Open();
            cn.Execute("sp_EliminarCategoria", parametros, commandType: CommandType.StoredProcedure);
            cn.Close();
        }

        public List<Categorias> ListadoCategorias()
        {
            List<Categorias> lista = new List<Categorias>();
            IDbConnection cn = Conexion.Conexion.Conectar();
            cn.Open();
            lista = cn.Query<Categorias>("sp_ConsultarCategorias", commandType: CommandType.StoredProcedure).ToList();
            cn.Close();
            return lista;
        }
    }
}
