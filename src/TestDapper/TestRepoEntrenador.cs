using Biblio;
using Biblio.ConDapper;

namespace TestDapper;

public class TestRepoEntrenador : TestRepo
{
    RepoEntrenador _repo;
    public TestRepoEntrenador() : base()
        => _repo = new RepoEntrenador(_conexion);
    
    [Fact]
    public void AltaEntrenadorOK()
    {
        var federico = new Entrenador()
        {
            Id = 0,
            Nombre = "FedericoM",
            Dinero = 1000
        };
        _repo.Alta(federico);

        Assert.NotEqual(0, federico.Id);
    }

    [Fact]
    public void TraerMochila()
    {
        var mochiLuchoxx87 = _repo.TraerMochila(3);
        Assert.NotEmpty(mochiLuchoxx87);
        Assert.Contains(mochiLuchoxx87, o=> o.Key.Nombre=="Poké Ball" && o.Value == 6);
    }

    [Fact]
    public void TraerEntrenadoresOK()
    {
        var entrenadores = _repo.ObtenerEntrenadores();
    
        Assert.NotEmpty(entrenadores);
        Assert.Contains(entrenadores, e=> e.Nombre == "luchoxx87");
    }
}
