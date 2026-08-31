namespace Biblio.Repos;

public interface IRepoEspecie
{
    public void AltaEspecie(Especie especie);
    IEnumerable<Especie> ObtenerEspecies();
}
