using AwesomeAssertions;

namespace CajeroAutomatico;

public class UnitTest1
{
    [Fact]
    public void Saldo_A_Retirar_Excede_El_Saldo_Que_Hay_En_El_Cajero()
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
        int saldoCajero = 5100;
            
        return saldoRetirar<saldoCajero;
    }
}