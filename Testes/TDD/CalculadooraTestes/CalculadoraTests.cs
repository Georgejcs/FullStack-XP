using Calculadora.Services;

namespace CalculadooraTestes;

public class CalculadoraTests
{
    private CalculadoraImp _calc;
        
    public CalculadoraTests()
    {
        _calc = new CalculadoraImp("08/11/2024");
    }
   
   [Theory]
   [InlineData (1, 2, 3)]
   [InlineData (4, 5, 9)]
   public void TestarSomar(int num1, int num2, int resultadoEsperado)
   {
        // Act
        int resultado = _calc.Somar(num1, num2);

        // Assert
        Assert.Equal(resultadoEsperado, resultado);
   }

   [Theory]
   [InlineData (3, 2, 1)]
   [InlineData (5, 4, 1)]
   public void TestarSubtrair(int num1, int num2, int resultadoEsperado)
   {
        // Act
        int resultado = _calc.Subtrair(num1, num2);

        // Assert
        Assert.Equal(resultadoEsperado, resultado);
   }

   [Theory]
   [InlineData (3, 2, 6)]
   [InlineData (5, 4, 20)]
   public void TestarMultiplicar(int num1, int num2, int resultadoEsperado)
   {
        // Act
        int resultado = _calc.Multiplicar(num1, num2);

        // Assert
        Assert.Equal(resultadoEsperado, resultado);
   }

   [Theory]
   [InlineData (40, 2, 20)]
   [InlineData (16, 4, 4)]
   public void TestarDividir(int num1, int num2, int resultadoEsperado)
   {
        // Act
        int resultado = _calc.Dividir(num1, num2);

        // Assert
        Assert.Equal(resultadoEsperado, resultado);
   }

   [Fact]
   public void TestarDivisaoPorZero()
   {
        // Assert
        Assert.Throws<DivideByZeroException>(
            () => _calc.Dividir(3, 0)
        );
   }

   [Fact]
   public void TestarHistorico()
   {
        // Act
        _calc.Somar(1, 2);
        _calc.Somar(7, 5);
        _calc.Somar(5, 10);
        _calc.Somar(8, 12);

        var listaHistorico = _calc.Historico();
        // Assert
        Assert.NotEmpty(listaHistorico);
        Assert.Equal(3, listaHistorico.Count);
   }
}