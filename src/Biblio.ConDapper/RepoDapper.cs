using System.Data;

namespace Biblio.ConDapper;

public abstract class RepoDapper
{
    protected readonly IDbConnection Conexion;

    public RepoDapper(IDbConnection conexion) => Conexion = conexion;
}
