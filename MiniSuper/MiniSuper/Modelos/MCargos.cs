using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Dapper;
using MiniSuper.Entidades;

namespace MiniSuper.Modelos
{
    public class MCargos
    {
        public void RegistrarCargo(Cargos c)
        {
            IDbConnection cn = Conexion.Conexion.Conectar();
            DynamicParameters paramentros = new DynamicParameters();
            paramentros.Add("@nombreCargo", c.nombreCargo, DbType.String);
            paramentros.Add("@sueldo", c.sueldo, DbType.Double);
            cn.Open();
            cn.Execute("sp_InsertarCargo", paramentros, commandType: CommandType.StoredProcedure);
            cn.Close();
        }

        public void ActualizarCargo(Cargos c)
        {
            IDbConnection cn = Conexion.Conexion.Conectar();
            DynamicParameters parametros = new DynamicParameters();
            parametros.Add("@id", c.idCargo, DbType.Int32);
            parametros.Add("@nuevoNombre", c.nombreCargo, DbType.String);
            parametros.Add("@nuevoSueldo", c.sueldo, DbType.Double);
            cn.Open();
            cn.Execute("sp_ModificarCargo", parametros, commandType: CommandType.StoredProcedure);
            cn.Close();
        }

        public void EliminarCargo(Cargos c)
        {
            IDbConnection cn = Conexion.Conexion.Conectar();
            DynamicParameters parametros = new DynamicParameters();
            parametros.Add("@id", c.idCargo, DbType.Int32);
            cn.Open();
            cn.Execute("sp_EliminarCargo", parametros, commandType: CommandType.StoredProcedure);
            cn.Close();
        }

        public List<Cargos> ListadoCargos()
        {
            List<Cargos> lista = new List<Cargos>();
            IDbConnection cn = Conexion.Conexion.Conectar();
            cn.Open();
            lista = cn.Query<Cargos>("sp_ConsultarCargos", commandType: CommandType.StoredProcedure).ToList();
            cn.Close();
            return lista;
        }
    }
}
