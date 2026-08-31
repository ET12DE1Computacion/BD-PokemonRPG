namespace Biblio.Repos;

public interface IRepoEntrenador
{
    IEnumerable<Entrenador> ObtenerEntrenadores();
    void Alta(Entrenador entrenador);
    IDictionary<Objeto, ushort> TraerMochila(short idEntrenador);
}
