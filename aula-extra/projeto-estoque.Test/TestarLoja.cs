using System.Globalization;
using Xunit;
using FluentAssertions;

namespace projeto_estoque.Test;

public class TestarLoja
{
    [Theory(DisplayName = "Testa se é possível criar uma loja")]
    [InlineData("Xablau", 20)]
    [InlineData("Loja 1", 50)]
    public void TestCriarLoja(string nomeLoja, int qtdTotalProdutos)
    {
        var instance = new Loja(nomeLoja, qtdTotalProdutos);
        instance.NomeLoja.Should().Be(nomeLoja);
        instance.Estoque.Length.Should().Be(qtdTotalProdutos);
    }
    
    [Theory(DisplayName = "Testa se é possível adicionar produto ao estoque da loja")]
    [InlineData("Pilha", 20, 2.5)]
    [InlineData("Relógio", 50, 50.00)]
    public void TestAdicionarProduto(string nome, int unidades, double valor)
    {
        var instance = new Loja("nomeLoja", 50);
        var result = instance.AdicionarProduto(nome, unidades, valor);
        
        result.Nome.Should().Be(nome);
        result.Unidades.Should().Be(unidades);
        result.Valor.Should().Be(valor);
    }
    
    [Theory(DisplayName = "Testa se é possível editar um produto do estoque da loja")]
    [InlineData("Caneta", 10, 2.5)]
    [InlineData("Borracha", 10, 0.50)]
    public void TestEditarProduto(string nome, int unidades, double valor)
    {
        var instance = new Loja("nomeLoja1", 50);
        var result = instance.EditarProduto(nome, unidades, valor);
        
        result.Nome.Should().Be(nome);
        result.Unidades.Should().Be(unidades);
        result.Valor.Should().Be(valor);
    }
    
    [Theory(DisplayName = "Testa se falha ao adicionar mais produtos do que tem espaço na loja")]
    [InlineData("Pilha", 20, 2.5)]
    [InlineData("Relógio", 50, 50.00)]
    public void TestAdicionarProdutoFail(string nome, int unidades, double valor)
    {
        var instance = new Loja("nomeLoja", 1);
        instance.AdicionarProduto("nome", 1, 1);
    
        Action act = () => instance.AdicionarProduto(nome, unidades, valor);
        act.Should().Throw<IndexOutOfRangeException>();
        //.WithMessage("O estoque já esta cheio.");
    }
    
    [Theory(DisplayName = "Testa se é possível listar os produtos da loja")]
    [InlineData("Caneta", 10, 2.5)]
    [InlineData("Borracha", 10, 0.50)]
    [InlineData("Notebook", 10, 1000.50)]
    public void TestListarProduto(string nome, int unidades, double valor)
    {
        var strWriter = new StringWriter();
        var consoleDefault = Console.Out;
        
        Console.SetOut(strWriter); // qdo executar o listarProdutos, o console será lançado para dentro do strWriter
        
        var instance = new Loja("nomeLoja1", 50);
        instance.AdicionarProduto(nome, unidades, valor);
        instance.ListarProdutos();

        var result = strWriter.ToString().Trim().Split(Environment.NewLine);
        result[0].Should().Contain(nome);
        result[1].Should().Contain(unidades.ToString());
        result[2].Should().Contain(valor.ToString("C", new CultureInfo("en-us")));
        
        Console.SetOut(consoleDefault); // limpa o console para a versão anterior deste teste
    }
    
    [Theory(DisplayName = "Testa se executa o programa")]
    [InlineData(new object[] { new string[] { "Kerli", "50", "Caneta", "10", "2,5" }})]
    [InlineData(new object[] { new string[] { "Loja", "50", "Borracha", "10", "2,5" }})]
    public void TestExecutaPrograma(string[] entries)
    {
        var strWriter = new StringWriter();
        var consoleOutDefault = Console.Out;
        Console.SetOut(strWriter); // qdo executar o listarProdutos, o console será lançado para dentro do strWriter
        var strReader = new StringReader(string.Join(Environment.NewLine, entries));
        var consoleInDefault = Console.In;
        Console.SetIn(strReader);
        
        Program.Main();
        // var act = () => Program.Main();
        
        // var result = strWriter.ToString().Trim().Split(Environment.NewLine);
        // result[0].Should().Contain(nome);
        // result[1].Should().Contain(unidades.ToString());
        // result[2].Should().Contain(valor.ToString("C", new CultureInfo("en-us")));

        Console.SetOut(consoleOutDefault); // limpa o console para a versão anterior deste teste
        Console.SetIn(consoleInDefault);

        Console.WriteLine(strWriter);
    }
}