using AwesomeAssertions;

namespace CajeroAutomatico;

public class UnitTest1
{
    [Fact]
    public void Test1()
    {
        //arrange
        int saldoRetirar = 5300;
        //act
        var resultado = RetiroCajero(saldoRetirar);
        //assert
        resultado.Should().Be(false);
    }

    private object RetiroCajero(int saldoRetirar)
    {
        throw new NotImplementedException();
    }
}