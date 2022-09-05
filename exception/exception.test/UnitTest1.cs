using Xunit;
using FluentAssertions;
namespace math_operations.test;

public class UnitTest1
{
    [Theory(DisplayName = "Teste para lançamento de exceção em divisão entre dois números inteiros.")]
    [InlineData(2013, 0)]
    [InlineData(5, 0)]
    public void TestDivideNumbersException(int numberOne, int numberTwo)
    {
        // var mathOperations = MathOperations.DivideNumbers(numberOne, numberTwo);

        Action act = () =>  MathOperations.DivideNumbers(numberOne, numberTwo);

        act.Should().Throw<DivideByZeroException>().WithMessage("Não pode dividir um número por zero!");
    }
    
    [Theory(DisplayName = "Teste para lançamento de exceção em divisão entre dois números inteiros.")]
    [InlineData(5, 4)]
    [InlineData(10, 2)]
    public void TestDivideNumbers(int numberOne, int numberTwo)
    {
        var ex = MathOperations.DivideNumbers(numberOne, numberTwo);

        ex.Should().BePositive();
    }
    
    [Theory(DisplayName = "Teste de exceção para nome com valor nulo passado como parâmetro.")]
    [InlineData(null)]
    public void TestWriteNameException(string name)
    {
        Action act = () => MathOperations.WriteName(name);

        act.Should().Throw<ArgumentNullException>();
    }
    
    [Theory(DisplayName = "Teste de exceção para nome com valor nulo passado como parâmetro.")]
    [InlineData("Ariel")]
    [InlineData("Ale")]
    [InlineData("Cris")]
    public void TestWriteName(string name)
    {
        using var strWriter = new StringWriter();
        Console.SetOut(strWriter);
        
        MathOperations.WriteName(name);

        var result = strWriter.ToString().Trim().Split("\n");
        result[0].Should().Contain($"{name}");
    }
}