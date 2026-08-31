using System.Data;
using Biblio.Repos;
using Dapper;

namespace Biblio.ConDapper;

public class RepoEntrenador : RepoDapper, IRepoEntrenador
{
    public RepoEntrenador(IDbConnection conexion)
        : base(conexion) { }

    public void Alta(Entrenador entrenador)
    {
        var parametros = new DynamicParameters();
        parametros.Add("unId", direction: ParameterDirection.Output);
        parametros.AddDynamicParams(
            new
            {
                unNombre = entrenador.Nombre,
                unMonto = entrenador.Dinero
            }
        );

        Conexion.Execute("AltaEntrenador", parametros, commandType: CommandType.StoredProcedure);
        entrenador.Id = parametros.Get<short>("unId");
    }

    public IEnumerable<Entrenador> ObtenerEntrenadores()
    {
        string query =
            @"SELECT    idEntrenador Id,
                        nombre,
                        dinero
            FROM Entrenador";
        var entrenadores = Conexion.Query<Entrenador>(query);
        return entrenadores;
    }

    public IDictionary<Objeto, ushort> TraerMochila(short idEntrenador)
    {
        var resultados = Conexion.Query<Objeto, ushort, (Objeto objeto, ushort cantidad)>
        (
            "MochilaDe",
            (objeto, cantidad) => (objeto, cantidad),
            new { unIdEntrenador = idEntrenador },
            splitOn: "cantidad",
            commandType: CommandType.StoredProcedure
        );

        // Convertimos la lista de tuplas al Diccionario esperado
        return resultados.ToDictionary(r => r.objeto, r => r.cantidad);
    }
}
