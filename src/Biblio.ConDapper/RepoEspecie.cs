using System.Data;
using Biblio.Repos;
using Dapper;

namespace Biblio.ConDapper;

public class RepoEspecie : RepoDapper, IRepoEspecie
{
    public RepoEspecie(IDbConnection conexion)
        : base(conexion) { }

    static readonly string listado =
        @"SELECT 
            -- Propiedades de Especie
            e.idEspecie AS Id,
            e.nombre AS Nombre,
            e.altura AS Altura,
            e.peso AS Peso,
            e.probabilidadH AS ProbabilidadHembra,                
            -- Propiedades de Tipo
            t.idTipo AS Id,
            t.tipo AS Nombre,                
            -- Propiedades de Tipo 2
            t2.idTipo AS Id,
            t2.tipo AS Nombre
        FROM Especie e
        INNER JOIN Tipo t USING (idTipo)
        LEFT JOIN Tipo t2 ON e.idTipo2 = t2.idTipo
        ORDER BY idEspecie ASC";

    public void AltaEspecie(Especie especie)
    {
        throw new NotImplementedException();
    }
/*
    public IEnumerable<Especie> ObtenerEspecies()
    {
        var especies = Conexion.Query<Especie, Tipo, Tipo, Especie>(
            listado,
            (especie, tipo, tipo2) =>
            {
                especie.Tipo = tipo;
                especie.Tipo2 = tipo2;
                return especie;
            },
            splitOn: "Id, Id"
        );
        return especies;
    }*/
    public IEnumerable<Especie> ObtenerEspecies()
    {
        var comparadorTipos = EqualityComparer<Tipo>.Create(
            (t1, t2) => t1 != null && t2 != null && t1.Id == t2.Id,
            p => p.Id.GetHashCode()
        );
        var tipos = new HashSet<Tipo>(comparadorTipos);
        var especies = Conexion.Query<Especie, Tipo, Tipo, Especie>(
            listado,
            (especie, tipo, tipo2) =>
            {
                tipos.Add(tipo);
                tipos.TryGetValue(tipo, out var tipoUnico);
                especie.Tipo = tipoUnico!;

                if (tipo2 != null)
                {
                    tipos.Add(tipo2);
                    tipos.TryGetValue(tipo2, out var tipo2Unico);
                    especie.Tipo2 = tipo2Unico;
                }

                return especie;
            },
            splitOn: "Id, Id"
        );
        return especies;
    }
}
