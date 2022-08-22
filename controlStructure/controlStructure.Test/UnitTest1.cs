using Xunit;
using FluentAssertions;

using control_Structure;

namespace controlStructure.Test;

public class UnitTest1
{
    [Theory(DisplayName = "Deve classificar um triangulo")]
    [InlineData(2,2,2, "Triângulo Equilátero")]
    [InlineData(5,6,6, "Triângulo Isóscele")]
    [InlineData(6,2,6, "Triângulo Isóscele")]
    [InlineData(6,6,2, "Triângulo Isóscele")]
    [InlineData(1,2,3, "Triângulo Escaleno")]
    public void TestIdentifyTriangle(double xSide, double ySide, double zSide, string name)
    {
        var resultName = ControlStructure.IdentifyTriangle(xSide, ySide, zSide);
        resultName.Should().Be(name);
    }

    [Theory(DisplayName = "Deve classificar um polígono.")]
    [InlineData(2,"Não é um polígono")]
    [InlineData(3,"Triângulo")]
    [InlineData(4,"Quadrado")]
    [InlineData(5,"Pentágono")]
    [InlineData(6,"Polígono não identificado")]
    public void TestIdentifyPolygon(int sideCount, string name)
    {
        var resultName = ControlStructure.IdentifyPolygon(sideCount);

        resultName.Should().Be(name);
    }
}