using AwesomeAssertions;

namespace ConstruirArbolNavidad;

public class UnitTest1
{
    [Theory]
    [InlineData(2)]
    [InlineData(3)]
    [InlineData(4)]
    public void Determinar_Numero_Esquema_Arbol_Navidad(int altura)
    {
                //act
                var resultado = CreacionArbol(altura);
                //assert
                resultado.Should().Be(altura*altura+1);
    }

    private int CreacionArbol(int altura)
    {
        
        int numero = 1;
        int resultado = 0;
        for (int i = 0; i < altura; i++)
        {
            for (int y = 0; y < numero; y++)
            {
                Console.Write('X');
            }
            resultado=resultado+numero;
            numero=numero + 2;
            Console.Write('\n');
        }
        Console.Write('|');
        return resultado+1;
    }
}