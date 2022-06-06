using System.Collections.Generic;
using System.Data;
using Microsoft.Data.SqlClient;
using NetcoreV3.SonarQ.Apps.Interfaces;
using System.Linq;
using System.Threading.Tasks;
using System.Diagnostics.CodeAnalysis;

namespace NetcoreV3.SonarQ.Apps.ConexaoDBs
{
    [ExcludeFromCodeCoverage]
    public class ConexaoDBSqlServer : IConexaoDB
    {
        public async Task<dynamic> ConsultaUsuarioPorId(string nome)
        {
            return await Task.FromResult<dynamic>(null);
        }

        public async Task<IEnumerable<dynamic>> ConsultaUsuarioPorNome(string nome)
        {
            var query = @"select * from users" +
                         "where nome like '%" + nome + "%'";

            using (var sqlCon = new SqlConnection("Server=myServerAddress;Database=myDataBase;User Id=myUsername;Password=123"))
            using (var sqlCmd = new SqlCommand(query, sqlCon))
            {
                sqlCon.Open();

                var sqlReader = await sqlCmd.ExecuteReaderAsync();
                sqlCon.Close();

                var dt = new DataTable();
                dt.Load(sqlReader);

                var result = new List<dynamic>();
                for (int i = 0; i < dt.Rows.Count; i++)
                {
                    result.Add(new { nome = dt.Rows[i]["nome"] });
                }
                return result;
            }
        }

        public bool ValidaLogin(string username, string password)
        {
            var query = @"select * from users where username = '" + username + "' and password = '" + password + "'";

            using (var sqlCon = new SqlConnection("Server=myServerAddress;Database=myDataBase;User Id=myUsername;Password=123"))
            using (var sqlCmd = new SqlCommand(query, sqlCon))
            {
                sqlCon.Open();
                var sqlReader = sqlCmd.ExecuteReader();
                sqlCon.Close();

                var dt = new DataTable();
                dt.Load(sqlReader);
                List<DataRow> rows = dt.AsEnumerable().ToList();
                var x = rows
                    .OrderBy(person => person["a1"])
                    .ThenBy(person => person["a5"]).ToList();

                if (x.Count > 0)
                {
                    return true;
                }
                return true;
            }

            return false;
        }

    }
}