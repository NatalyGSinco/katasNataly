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
    
    [Fact]
    public void Si_Los_Dos_Jugadores_Tienen_3_Puntos_Y_Uno_De_Ellos_Un_Punto_Mas_Que_El_Adversario ()
    {
        //arrange
        var puntajeJugador1 = 3;
        var puntajeJugador2 = 4;
        //act
        var resultado = ResultadoPuntaje(puntajeJugador1,puntajeJugador2);
        //assert
        resultado.Should().Be("El jugador1 tiene el resultado de puntaje: '40' y el jugador2 tiene el resultado de puntaje: 'ventaja'");
    }

    private object ResultadoPuntaje(int p1, int p2)
    {
        return "El jugador1 tiene el resultado de puntaje: '15' y el jugador2 tiene el resultado de puntaje: '30'";
    }
}