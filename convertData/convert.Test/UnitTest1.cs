using Xunit;
using FluentAssertions;

namespace convert.Test;

public class UnitTest1
{
    [Fact]
    public void TestConvertCreation()
    {
        Class1 instance = new();
        var response = instance.someString is string;
        response.Should().Be(true);
    }

    [Fact]
    public void TestConvertConversion()
    {
        Class1 instance = new();

        instance.intEntry.Should().Be(42);
        var intTypeCheck = instance.intEntry is int;
        intTypeCheck.Should().Be(true);

        instance.Transform();

        instance.doubleResponse.Should().Be(42.0);
        var floatTypeCheck = instance.doubleResponse is double;
        floatTypeCheck.Should().Be(true);
    }

    [Fact]
    public void TestConvertDoConversion()
    {
        Class1 instance = new();
        instance.strEntry.Should().Be("42");
        var stringTypeCheck = instance.strEntry is string;
        stringTypeCheck.Should().Be(true);

        instance.DoConversion();

        instance.intResponse.Should().Be(42);
        var intTypeCheck = instance.intResponse is int;
        intTypeCheck.Should().Be(true);

    }
}