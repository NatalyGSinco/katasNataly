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

    [Fact]
    public void Reversar_Cadena()
    {
        //arrange
        var cadena = "5Oso5";
        //act
        var resultado = ValidarPalindromo(cadena);
        //assert
        resultado.Should().Be(false);
    }

    private Boolean ValidarPalindromo(string cadena)
    {
        string Patron = "[!\"·$%&/()=¿¡?'_:;,|@#€*+.]";
         string nuevaCadena =Regex.Replace(cadena.ToLower(),Patron, "");  
       Console.WriteLine(nuevaCadena); 
       char[] caracteres = nuevaCadena.ToCharArray();
       Array.Reverse(caracteres);
       string cadenaInvertida = new string(caracteres);
       
       
       if (nuevaCadena.Any(char.IsUpper))
        {
            return false;
        }
        if ( Regex.IsMatch(nuevaCadena, Patron))
        {
            
            return false;
        }

        if (nuevaCadena!=cadenaInvertida)
        {
            return false;
        }
        return true;
    }
}