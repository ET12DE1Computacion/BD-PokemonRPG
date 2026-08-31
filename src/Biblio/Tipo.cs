namespace Biblio;

public class Tipo
{
    public byte Id { get; set; }
    public required string Nombre { get; set; }
    public override string ToString() => Nombre;
}