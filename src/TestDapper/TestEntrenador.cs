using Biblio;
using Biblio.ConDapper;

namespace TestDapper;

public class TestEntrenador
{
    readonly Entrenador dimas;
    readonly Objeto pokebola;
    readonly Objeto ultrabola;
    public TestEntrenador()
    {
        pokebola = new Objeto()
        {
            Nombre = "Poke Ball",
            Compra = 200,
            Venta = 100,
            Id = 1
        };

        ultrabola = new()
        {
            Nombre = "Ultra Ball",
            Compra = 1200,
            Venta = 600,
            Id = 3
        };
        dimas = new ()
        {
            Nombre = "Dimas",
            Dinero = 5000,
            Id = 1,
            Mochila = new Dictionary<Objeto, ushort>()
            {
                [pokebola] = 2
            }
        };


    }

    [Fact]
    public void DimasTienePokebolasOK()
        => Assert.True(dimas.Posee(pokebola));

    [Fact]
    public void AgregarObjetoOK()
    {
        Assert.False(dimas.Posee(ultrabola));
        dimas.AgregarObjeto(ultrabola, 1);
        Assert.True(dimas.Posee(ultrabola));
    }

    [Fact]
    public void AgregarObjetoFalla()
    {
        Assert.Throws<ArgumentOutOfRangeException>
            (()=>dimas.AgregarObjeto(ultrabola, 0));
    }

    [Fact]
    public void SumarObjetosOK()
    {
        ushort cantidad = 8;
        var antes = dimas.Mochila[pokebola];

        dimas.AgregarObjeto(pokebola, cantidad);

        var cantidadNueva = dimas.Mochila[pokebola];
        Assert.Equal(antes+cantidad, cantidadNueva);
    }

    [Fact]
    public void UsarObjetoOK()
    {
        var antes = dimas.Mochila[pokebola];
        
        dimas.Usar(pokebola);

        Assert.Equal(antes - 1, dimas.Mochila[pokebola]);
    }

    [Fact]
    public void UsarObjetoFalla()
    {
        Assert.Throws<InvalidOperationException>
            (()=>dimas.Usar(ultrabola));
    }

    [Fact]
    public void UsarYEliminar()
    {
        dimas.Usar(pokebola);
        dimas.Usar(pokebola);

        Assert.False(dimas.Posee(pokebola));
    }
}
