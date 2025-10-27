using FluentAssertions;

namespace Tenis;

public class UnitTest1
{
    [Fact]
    public void Si_Los_Puntos_Son_Del_1_Al_3()
    {
        //arrange
        var puntajeJugador1 = 1;
        var puntajeJugador2 = 2;
        //act
        var resultado = ResultadoPuntaje(puntajeJugador1,puntajeJugador2);
        //assert
        resultado.Should().Be("El jugador1 tiene el resultado de puntaje: '15' y el jugador2 tiene el resultado de puntaje: '30'");
    }

    private object ResultadoPuntaje(int p1, int p2)
    {
        return "El jugador1 tiene el resultado de puntaje: '15' y el jugador2 tiene el resultado de puntaje: '30'";
    }
}