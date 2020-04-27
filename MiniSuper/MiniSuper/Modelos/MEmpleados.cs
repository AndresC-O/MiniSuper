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
    public class MEmpleados
    {
        public void RegistrarEmpleado(Empleados e)
        {
            IDbConnection cn = Conexion.Conexion.Conectar();
            DynamicParameters parametros = new DynamicParameters();
            parametros.Add("@nombreEmpleado", e.nombresEmpleado, DbType.String);
            parametros.Add("@apellidos", e.apellidosEmpleado, DbType.String);
            parametros.Add("@idCargo", e.idCargo, DbType.Int32);
            parametros.Add("@idSucursal", e.idSucursal, DbType.Int32);
            parametros.Add("@dui", e.dui, DbType.String);
            parametros.Add("@usuario", e.usuario, DbType.String);
            parametros.Add("@contrasenia", e.contrasenia, DbType.String);
            parametros.Add("@codigoEmpleado", e.codigoEmpleado, DbType.String);
            cn.Open();
            cn.Execute("sp_InsertarEmpleado", parametros, commandType: CommandType.StoredProcedure);
            cn.Close();
        }

        public void ActualizarEmpleado(Empleados e)
        {
            IDbConnection cn = Conexion.Conexion.Conectar();
            DynamicParameters parametros = new DynamicParameters();
            parametros.Add("@id", e.idEmpleado, DbType.Int32);
            parametros.Add("@nuevoNombre", e.nombresEmpleado, DbType.String);
            parametros.Add("@nuevoApellido", e.apellidosEmpleado, DbType.String);
            parametros.Add("@idCargo", e.idCargo, DbType.Int32);
            parametros.Add("@idSucursal", e.idSucursal, DbType.Int32);
            parametros.Add("@dui", e.dui, DbType.String);
            parametros.Add("@usuario", e.usuario, DbType.String);
            parametros.Add("@contrasenia", e.contrasenia, DbType.String);
            parametros.Add("@codigoEmp", e.codigoEmpleado, DbType.String);
            cn.Open();
            cn.Execute("sp_ModificarEmpleados", parametros, commandType: CommandType.StoredProcedure);
            cn.Close();
        }

        public void EliminarEmpleado(Empleados e)
        {
            IDbConnection cn = Conexion.Conexion.Conectar();
            DynamicParameters parametros = new DynamicParameters();
            parametros.Add("@id", e.idEmpleado, DbType.Int32);
            cn.Open();
            cn.Execute("sp_EliminarEmpleado", parametros, commandType: CommandType.StoredProcedure);
            cn.Close();
        }

        public List<Empleados> ListadoEmpleados()
        {
            List<Empleados> lista = new List<Empleados>();
            IDbConnection cn = Conexion.Conexion.Conectar();
            cn.Open();
            lista = cn.Query<Empleados>("sp_ConsultarEmpleados", commandType: CommandType.StoredProcedure).ToList();
            cn.Close();
            return lista;
        }
    }
}
