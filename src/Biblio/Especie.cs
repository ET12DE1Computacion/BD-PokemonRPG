namespace Biblio;
public class Especie
{
    public ushort Id { get; set; }
    public required Tipo Tipo { get; set; }
    public Tipo? Tipo2 { get; set; }
    public required string Nombre { get; set; }
    public float Altura { get; set; }
    public float Peso { get; set; }
    public float? ProbabilidadHembra { get; set; }
    public override string ToString() => Nombre;
    public bool EsTipo(Tipo tipo)
        => Tipo == tipo || (Tipo2 is not null && Tipo2 == tipo);
    public bool EsTipo(string nombreTipo)
        => Tipo.Nombre == nombreTipo ||
            (Tipo2 is not null && Tipo2.Nombre == nombreTipo);

}
