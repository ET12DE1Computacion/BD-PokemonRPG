using System.Data;
using MySqlConnector;

namespace TestDapper;

public abstract class TestRepo
{
    protected IDbConnection _conexion;
    public TestRepo()
    {
        var cadena = @"Server=localhost;Database=bd_PokemonRPG;User Id=5to_agbd;Password=Trigg3rs!;";
        _conexion = new MySqlConnection(cadena);
    }

}
