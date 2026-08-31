using System.Data;
using Biblio.Repos;
using Dapper;

namespace Biblio.ConDapper;

public class RepoObjeto : RepoDapper, IRepoObjeto
{
    public RepoObjeto(IDbConnection conexion)
        : base(conexion) {}

    public void Alta(Objeto objeto)
    {
        var param = new DynamicParameters();
        param.Add("unId", direction: ParameterDirection.Output);
        param.Add("unNombre", objeto.Nombre);
        param.Add("unPrecioVenta", objeto.Venta);
        param.Add("unPrecioCompra", objeto.Compra);

        Conexion.Execute("AltaObjeto", param, commandType: CommandType.StoredProcedure);
        objeto.Id = param.Get<short>("unId");
    }

    public IEnumerable<Objeto> ObtenerObjetos()
    {
        var listado =
            @"SELECT    idObjeto Id,
                        nombre,
                        precioVenta Venta,
                        precioCompra Compra
            FROM        Objeto
            ORDER BY    nombre ASC";
        var objetos = Conexion.Query<Objeto>(listado);
        return objetos;
    }
}
