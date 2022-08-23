using Xunit;
using FluentAssertions;
using iterationStructure;

namespace iterationStructure.Test;

public class UnitTest1
{
    [Theory(DisplayName = "Deve realizar a contagem do valor passado como parâmetro.")]
    [InlineData(new int[]{1, 1, 1}, 1, 3)]
    public void TestCountOf(int[] entnumbers, int value, int countExpected)
    {   
        var count = NumbersTools.CountOf(entnumbers, value);
        count.Should().Be(countExpected);
    }
}