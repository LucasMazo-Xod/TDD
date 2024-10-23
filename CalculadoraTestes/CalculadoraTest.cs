using Calculadora.Services;

namespace CalculadoraTestes;

public class CalculadoraTest
{
    private CalculadoraImp _calc;

    public CalculadoraTest()
    {
        _calc = new CalculadoraImp();
    }

    [Fact]
    public void DeveSomar5com10eRetornar15()
    {
        // Arrange
        int n5 = 5;
        int n10 =10;

        //Act
        int result = _calc.Somar(n5,n10);

        //Assert
         Assert.Equal(15, result);
    }
    [Fact]
    public void DeveSubtrair10com5eRetornar5()
    {
        // Arrange
        int n5 = 5;
        int n10 =10;

        //Act
        int result = _calc.Subtrair(n10,n5);

        //Assert
         Assert.Equal(5, result);
    }
    [Fact]
    public void Devemultiplicar10e5eRetornar50()
    {
        // Arrange
        int n5 = 5;
        int n10 =10;

        //Act
        int result = _calc.Multiplicar(n5,n10);

        //Assert
         Assert.Equal(50, result);
    }
    [Fact]
    public void Devedividir10com5eRetornar2()
    {
        // Arrange
        int n5 = 5;
        int n10 =10;

        //Act
        int result = _calc.Dividir(n10,n5);

        //Assert
         Assert.Equal(2, result);
    }
    [Fact]
    public void TestarDivisaoPor0()
    {

        //Assert
         Assert.Throws<DivideByZeroException>(
            () => _calc.Dividir(3,0)
         );
    }
    [Fact]
    public void TestarHistorico()
    {
        _calc.Somar(1,2);
        _calc.Somar(1,3);
        _calc.Somar(1,4);
        _calc.Somar(1,5);

        var lista = _calc.Historico();

        //Assert
         Assert.NotEmpty(lista);
         Assert.Equal(3, lista.Count);
    }

}
 