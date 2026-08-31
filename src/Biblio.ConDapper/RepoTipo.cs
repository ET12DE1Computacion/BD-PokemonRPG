using System.Data;
using Biblio.Repos;
using Dapper;

namespace Biblio.ConDapper;
public class RepoTipo : RepoDapper, IRepoTipo
{
    public RepoTipo(IDbConnection conexion)
        : base(conexion) {}
    static readonly string _sql =
        @"SELECT *
        FROM    vTipo";
    public IEnumerable<Tipo> ObtenerTipos()
    {
        var tipos = Conexion.Query<Tipo>(_sql);
        return tipos;
    }
}
