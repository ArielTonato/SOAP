using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using uta.fisei.credito.dominio;
using uta.fisei.credito.contrato;
using Dapper;
using System.Data.SqlClient;
using System.Data;

namespace uta.fisei.credito.sqlrepositorio
{
    public class ClienteRepositorio:IClienteService
    {
        public Cliente ObtenerCliente(string numeroDocumento)
        {
            using (IDbConnection conexion = new SqlConnection(ConexionBD.ObtenerCadenaConexion()))
            {
                conexion.Open();
                var parametros = new DynamicParameters();
                parametros.Add("pNumeroDocumento", numeroDocumento);

                var cliente = conexion.QuerySingle<Cliente>("dbo.sp_cliente_obtener", param: parametros, commandType: CommandType.StoredProcedure);

                return cliente;
            }
        }
        public IEnumerable<Cliente> ListarCliente()
        {
            using (IDbConnection conexion = new SqlConnection(ConexionBD.ObtenerCadenaConexion()))
            {
                conexion.Open();

                var cliente = conexion.Query<Cliente>("dbo.sp_cliente_listar", commandType: CommandType.StoredProcedure);

                return cliente;
            }
        }
    }
}
