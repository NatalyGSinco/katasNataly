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
    
    [Fact]
    public void Si_Los_Dos_Jugadores_Tienen_3_Puntos_Y_Son_Iguales_El_Puntaje ()
    {
        //arrange
        var puntajeJugador1 = 4;
        var puntajeJugador2 = 4;
        //act
        var resultado = ResultadoPuntaje(puntajeJugador1,puntajeJugador2);
        //assert
        resultado.Should().Be("El jugador1 tiene el resultado de puntaje: 'iguales' y el jugador2 tiene el resultado de puntaje: 'iguales'");
    }
    
    [Fact]
    public void Si_Un_Jugador_Tienen_4_Puntos_Y_Dos_Mas_Que_El_Adversario ()
    {
        //arrange
        var puntajeJugador1 = 7;
        var puntajeJugador2 = 3;
        //act
        var resultado = ResultadoPuntaje(puntajeJugador1,puntajeJugador2);
        //assert
        resultado.Should().Be("El jugador1 tiene el resultado de puntaje: 'pierde' y el jugador2 tiene el resultado de puntaje: 'gana'");
    }

    private object ResultadoPuntaje(int p1, int p2)
    {
        string resultadop1 = "";
        string resultadop2 = "";
        string mensajeResultado = "";
        if (p1 == 1)
        {
            resultadop1 = "'15'";
        }else if (p1 == 2)
        {
            resultadop1 = "'30'";
        }else if (p1 == 3)
        {
            resultadop1 = "'40'";
        }
        
        if (p2 == 1)
        {
            resultadop2 = "'15'";
        }else if (p2 == 2)
        {
            resultadop2 = "'30'";
        }else if (p2 == 3)
        {
            resultadop2 = "'40'";
        }

        if (p1 >= 3 && p2 >= 3)
        {
            if (p1-p2>0)
            {
                resultadop1 = "'ventaja'";
            }else if (p2 - p1 > 0)
            {
                resultadop2 = "'ventaja'";
            }
        }

        if (p1 >= 3 && p2 >= 3 && p1 == p2)
        {
            resultadop1 = "'iguales'";
            resultadop2 = "'iguales'";
        }

        mensajeResultado=$"El jugador1 tiene el resultado de puntaje: {resultadop1} y el jugador2 tiene el resultado de puntaje: {resultadop2}";
       return mensajeResultado;
    }
}