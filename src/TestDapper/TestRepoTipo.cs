using Biblio.ConDapper;
using Biblio.Repos;

namespace TestDapper;

public class TestRepoTipo : TestRepo
{
    IRepoTipo _repo;
    public TestRepoTipo() : base()
        => _repo = new RepoTipo(_conexion);

    [Theory]
    [InlineData("Agua")]
    [InlineData("Bicho")]
    [InlineData("Fuego")]
    public void TraerTiposOK(string tipo)
    {
        var tipos = _repo.ObtenerTipos();
        Assert.Contains(tipos, t=>t.Nombre == tipo);
    }
}
