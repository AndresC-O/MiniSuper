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
    public class MDocumentos
    {
        public void RegistrarDocumento(Documentos d)
        {
            IDbConnection cn = Conexion.Conexion.Conectar();
            DynamicParameters parametros = new DynamicParameters();
            parametros.Add("@tipoDocumento", d.tipoDocumento, DbType.String);
            cn.Open();
            cn.Execute("sp_InsertarDocumento", parametros, commandType: CommandType.StoredProcedure);
            cn.Close();
        }

        public void ActualizarDocumento(Documentos d)
        {
            IDbConnection cn = Conexion.Conexion.Conectar();
            DynamicParameters parametros = new DynamicParameters();
            parametros.Add("@id", d.idDocumento, DbType.Int32);
            parametros.Add("@nuevoDocumento", d.tipoDocumento, DbType.String);
            cn.Open();
            cn.Execute("sp_ModificarDocumento", parametros, commandType: CommandType.StoredProcedure);
            cn.Close();
        }

        public void EliminarDocumento(Documentos d)
        {
            IDbConnection cn = Conexion.Conexion.Conectar();
            DynamicParameters parametros = new DynamicParameters();
            parametros.Add("@id", d.idDocumento, DbType.Int32);
            cn.Open();
            cn.Execute("sp_EliminarDocumento", parametros, commandType: CommandType.StoredProcedure);
            cn.Close();
        }

        public List<Documentos> ListadoDocumentos()
        {
            List<Documentos> lista = new List<Documentos>();
            IDbConnection cn = Conexion.Conexion.Conectar();
            cn.Open();
            lista = cn.Query<Documentos>("sp_ConsultarDocumentos", commandType: CommandType.StoredProcedure).ToList();
            cn.Close();
            return lista;
        }
    }
}
