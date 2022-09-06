using Xunit;
using FluentAssertions;

namespace projeto_estoque.Test;

public class TestarLoja
{
    [Theory(DisplayName = "Testa se é posível criar uma loja")]
    [InlineData("Xablau", 20)]
    [InlineData("Loja 1", 50)]
    public void Test1()
    {

    }
}