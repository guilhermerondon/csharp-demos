using System.Data.SqlTypes;
using Microsoft.VisualStudio.TestPlatform.Common.Utilities;
using NewTalents;

namespace NewTalentsTest;

public class UnitTest1
{
    public Calculadora construirClasse()
    {
        string data = "02/02/2025";
        Calculadora calc = new Calculadora("02/02/2025");

        return calc;
    }
    


    [Theory]
    [InlineData (1, 2, 3)]
    public void TesteSomar(int num1, int num2, int resultado)
    {
        Calculadora calc  = construirClasse();

        int resultadoCalculadora = calc.somar(num1, num2);

        Assert.Equal(resultado, resultadoCalculadora);
    }

    [Theory]
    [InlineData (2, 1, 1)]
    public void TesteSubtrair(int num1, int num2, int resultado)
    {
        Calculadora calc = construirClasse();

        int resultadoCalculadora = calc.subtrair(num1, num2);

        Assert.Equal(resultado, resultadoCalculadora);
    }

    [Theory]
    [InlineData (1, 2, 2)]
    public void TesteMultiplicar(int num1, int num2, int resultado)
    {
        Calculadora calc  = construirClasse();

        int resultadoCalculadora = calc.multiplicar(num1, num2);

        Assert.Equal(resultado, resultadoCalculadora);
    }

    [Theory]
    [InlineData (4, 2, 2)]
    public void TesteDividir(int num1, int num2, int resultado)
    {
        Calculadora calc  = construirClasse();

        int resultadoCalculadora = calc.dividir(num1, num2);

        Assert.Equal(resultado, resultadoCalculadora);
    }

    [Fact]
    public void TestarDivisaoPorZero()
    {
        Calculadora calc = construirClasse();

        Assert.Throws<DivideByZeroException>(() => calc.dividir(3, 0)); 
    }

    [Fact]
    public void TestarHistorico()
    {
        Calculadora calc = construirClasse();

        calc.somar(1, 2);
        calc.somar(2, 2);
        calc.somar(5, 5);
        calc.somar(4, 6);

        var lista = calc.historico();

        Assert.NotEmpty(calc.historico());
        Assert.Equal(3, lista.Count);
    }
}