namespace Biblio;

public class Entrenador
{
    public short Id { get; set; }
    public required string Nombre { get; set; }
    public uint Dinero { get; set; }
    public IDictionary<Objeto, ushort> Mochila { get; set; }
        = new Dictionary<Objeto, ushort>();
    public void AgregarObjeto(Objeto objeto, ushort cantidad)
    {
        if(cantidad == 0)
            throw new ArgumentOutOfRangeException("Cantidad no puede ser cero");
            
        if (!Mochila.TryAdd(objeto, cantidad))
            Mochila[objeto] += cantidad;
    }
    public bool Posee (Objeto objeto) => Mochila.ContainsKey(objeto);
    public void Usar (Objeto objeto)
    {
        if (!Posee(objeto))
            throw new InvalidOperationException($"No posee: {objeto.Nombre}");
        
        Mochila[objeto]--;
        if (Mochila[objeto] == 0)
            Mochila.Remove(objeto);
    }
}