using System.Text.RegularExpressions;
using AwesomeAssertions;

namespace Palindromos;

public class UnitTest1
{
    [Fact]
    public void Ignorar_Mayusculas_Y_Minusculas_De_La_Cadena()
    {
        //arrange
        var cadena = "Oso";
        //act
        var resultado = ValidarPalindromo(cadena);
        //assert
        resultado.Should().Be(true);
    }

    [Fact]
    public void Ignorar_Los_Signos_De_La_Cadena()
    {
        //arrange
        var cadena = "Oso!";
        //act
        var resultado = ValidarPalindromo(cadena);
        //assert
        resultado.Should().Be(true);
    }

    [Theory]
    [InlineData("anna!")]
    [InlineData("RaceCar")]
    
    public void Reversar_Cadena_Si_Es_PaLindromo_Deberia_Dar_Verdadero(string cadena)
    {
        //act
        var resultado = ValidarPalindromo(cadena);
        //assert
        resultado.Should().Be(true);
    }
    
    [Theory]
    [InlineData("5Oso")]
    [InlineData("Hello, World!")]

    public void Reversar_Cadena_Si_No_Es_PaLindromo_Deberia_Dar_Falso(string cadena)
    {
        //act
        var resultado = ValidarPalindromo(cadena);
        //assert
        resultado.Should().Be(false);
    }

    private Boolean ValidarPalindromo(string cadena)
    {
        string Patron = "[!\"·$%&/()=¿¡?'_:;,|@#€*+.]";
        
        string nuevaCadena =Regex.Replace(cadena.ToLower(),Patron, "");  
     
       char[] caracteres = nuevaCadena.ToCharArray();
       Array.Reverse(caracteres);
       string cadenaInvertida = new string(caracteres);
       
       
       if (nuevaCadena.Any(char.IsUpper) || Regex.IsMatch(nuevaCadena, Patron) || nuevaCadena!=cadenaInvertida)
        {
            return false;
        }
        return true;
    }
}