using Biblio;
using Biblio.ConDapper;
using Biblio.Repos;
using Xunit;

namespace TestDapper;
public class TestRepoObjeto : TestRepo
{
    IRepoObjeto _repo;
    public TestRepoObjeto() : base()
        => _repo = new RepoObjeto(_conexion);

    [Fact]
    public void CrearHonorBola()
    {
        var honorbola = new Objeto()
        {
            Nombre = "Honor Ball",
            Compra = 200,
            Venta = 100
        };
        
        Assert.Equal(0, honorbola.Id);
        _repo.Alta(honorbola);

        Assert.NotEqual(0, honorbola.Id);
    }

    [Fact]
    public void TraerPiedraFuego()
    {
        var objetos = _repo.ObtenerObjetos();

        Assert.NotEmpty(objetos);
        Assert.Contains(objetos, o=> o.Nombre == "Piedra fuego");
    }

    [Fact]
    public void TestName()
    {
        // Given
    
        // When
    
        // Then
    }
}
