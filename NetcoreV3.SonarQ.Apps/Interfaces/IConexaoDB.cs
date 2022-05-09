using System.Collections.Generic;
using System.Threading.Tasks;

namespace NetcoreV3.SonarQ.Apps.Interfaces
{
    public interface IConexaoDB
    {
         bool ValidaLogin(string username, string password);
         Task<IEnumerable<dynamic>> ConsultaUsuarioPorNome(string nome);
         Task<dynamic> ConsultaUsuarioPorId(string nome);
    }
}