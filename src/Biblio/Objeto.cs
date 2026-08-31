using System.Diagnostics.CodeAnalysis;

namespace Biblio;

public class Objeto
{
    public short Id { get; set; }
    public required string Nombre { get; set; }
    public ushort Venta { get; set; }
    public ushort Compra { get; set; }
    public override string ToString() => Nombre;
}