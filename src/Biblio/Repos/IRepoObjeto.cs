namespace Biblio.Repos;

public interface IRepoObjeto
{
    IEnumerable<Objeto> ObtenerObjetos();
    void Alta(Objeto objeto);
}