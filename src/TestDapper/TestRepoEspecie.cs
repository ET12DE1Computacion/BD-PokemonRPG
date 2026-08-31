using Biblio.ConDapper;
using Biblio.Repos;

namespace TestDapper;

public class TestRepoEspecie : TestRepo
{
    IRepoEspecie _repo;
    public TestRepoEspecie() : base()
        => _repo = new RepoEspecie(_conexion);

    [Fact]
    public void ObtenerEspeciesOK()
    {
        var especies = _repo.ObtenerEspecies();
        IEnumerable<string> nombres = ["Pikachu", "Caterpie", "Arcanine", "Mew"];

        Assert.NotEmpty(especies);
        Assert.True(nombres.All(n => especies.Any(e=>e.Nombre == n)));
    }
}
