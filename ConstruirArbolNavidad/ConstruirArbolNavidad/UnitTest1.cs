using AwesomeAssertions;

namespace ConstruirArbolNavidad;

public class UnitTest1
{
    [Fact]
    public void Test1()
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
        return altura;
    }
}