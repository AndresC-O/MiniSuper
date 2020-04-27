using MiniSuper.Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Dapper;
using System.Data;
using System.Threading.Tasks;

namespace MiniSuper.Modelos
{
    public class MClientes
    {
        public void RegistrarCliente(Clientes cl)
        {
            IDbConnection cn = Conexion.Conexion.Conectar();
            DynamicParameters parametros = new DynamicParameters();
            parametros.Add("@nombresCliente", cl.nombreCliente, DbType.String);
            parametros.Add("@apellidosCliente", cl.apellidosCliente, DbType.String);
            parametros.Add("@direccion", cl.direccion, DbType.String);
            parametros.Add("@telefono", cl.telefono, DbType.String);
            parametros.Add("@dui", cl.dui, DbType.String);
            parametros.Add("@nit", cl.nit, DbType.String);
            cn.Open();
            cn.Execute("sp_InsertarCliente", parametros, commandType: CommandType.StoredProcedure);
            cn.Close();
        }

        public void ActualizarCliente(Clientes cl)
        {
            IDbConnection cn = Conexion.Conexion.Conectar();
            DynamicParameters parametros = new DynamicParameters();
            parametros.Add("@id", cl.idCliente, DbType.Int32);
            parametros.Add("@nuevosNombres", cl.nombreCliente, DbType.String);
            parametros.Add("@nuevosApellidos", cl.apellidosCliente, DbType.String);
            parametros.Add("@direccion", cl.direccion, DbType.String);
            parametros.Add("@telefono", cl.telefono, DbType.String);
            parametros.Add("@dui", cl.dui, DbType.String);
            parametros.Add("@nit", cl.nit, DbType.String);
            cn.Open();
            cn.Execute("sp_ModificarCliente", parametros, commandType: CommandType.StoredProcedure);
            cn.Close();
        }

        public void EliminarCliente(Clientes cl)
        {
            IDbConnection cn = Conexion.Conexion.Conectar();
            DynamicParameters parametros = new DynamicParameters();
            parametros.Add("@id", cl.idCliente, DbType.Int32);
            cn.Open();
            cn.Execute("sp_EliminarCliente", parametros, commandType: CommandType.StoredProcedure);
            cn.Close();
        }

        public List<Clientes> ListadoClientes()
        {
            List<Clientes> lista = new List<Clientes>();
            IDbConnection cn = Conexion.Conexion.Conectar();
            cn.Open();
            lista = cn.Query<Clientes>("sp_ConsultarClientes", commandType: CommandType.StoredProcedure).ToList();
            cn.Close();
            return lista;
        }
    }
}
