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
    
    [Fact]
    public void Saldo_A_Retirar_No_Excede_El_Saldo_Que_Hay_En_El_Cajero()
    {
        //arrange
        int saldoRetirar = 3000;
        //act
        var resultado = RetiroCajero(saldoRetirar);
        //assert
        resultado.Should().Be(true);
    }

    private object RetiroCajero(int saldoRetirar)
    {
        int saldoCajero = 5100;
        
        if (saldoRetirar!=5100)
        {
            Console.WriteLine("El cajero automático no dispone de dinero suficiente, por favor acuda al cajero automático más cercano");
            return false;
        }
        return true;
        
    }
}