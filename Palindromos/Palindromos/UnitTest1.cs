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

    private Boolean ValidarPalindromo(string cadena)
    {
        string Patron = "[!\"·$%&/()=¿¡?'_:;,|@#€*+.]";
         string nuevaCadena =Regex.Replace(cadena.ToLower(),Patron, "");  
       Console.WriteLine(nuevaCadena); 
       if (nuevaCadena.Any(char.IsUpper))
        {
            return false;
        }
        if ( Regex.IsMatch(nuevaCadena, Patron))
        {
            
            return false;
        }
        return true;
    }
}