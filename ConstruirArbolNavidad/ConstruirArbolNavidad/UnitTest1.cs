using AwesomeAssertions;

namespace ConstruirArbolNavidad;

public class UnitTest1
{
    [Fact]
    public void Determinar_Numero_Esquema_Arbol_Navidad()
    {
        //arrange
                var altura = 2;
                //act
                var resultado = CreacionArbol(altura);
                //assert
                resultado.Should().Be(5);
    }

    private int CreacionArbol(int altura)
    {
        
        return altura*altura+1;
    }
}