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

    [Theory]
    [InlineData(1700)]
    [InlineData(900)]
    public void Saldo_A_Retirar_No_Excede_El_Saldo_Que_Hay_En_El_Cajero(int saldoRetirar)
    {
        //act
        var resultado = RetiroCajero(saldoRetirar);
        //assert
        resultado.Should().Be(true);
    }

    private object RetiroCajero(int saldoRetirar)
    {
        //Estado inicial del cajero automático
        int[] valor = { 500, 200, 100, 50, 20, 10, 5, 2, 1 };
        int[] cantidadDelvalor = { 2, 3, 5, 12, 20, 50, 100, 250, 500 };
        
        //Saldo cajero
        int saldoCajero = 5100;
        int valorDescontar = saldoRetirar;
       

        if (saldoRetirar > saldoCajero)
        {
            Console.WriteLine(
                "El cajero automático no dispone de dinero suficiente, por favor acuda al cajero automático más cercano");
            return false;
        }


        for (int i = 0; i < cantidadDelvalor.Length; i++)
        {
            int cantidadDisponible = cantidadDelvalor[i];
            if (valorDescontar != 0){
                for (int y = 0; y < cantidadDisponible; y++)
                {
                        if (valorDescontar >= valor[i])
                        {
                            valorDescontar = valorDescontar - valor[i];
                            cantidadDelvalor[i] = cantidadDelvalor[i] - 1;
                        }
                    else
                    {
                        break;
                    }
                }
            }else{break;}
        }

        if (valorDescontar == 0)
        {
            Console.WriteLine(
                "El valor a descontar quedo en: " + valorDescontar +
                ". Se entrego correctamente todo el saldo a retirar");
        }

        return true;

    }

}