using System.Globalization;

namespace projeto_estoque;

public class Loja
{
    private readonly string nomeLoja;
    private Produto[] estoque;
    private int qtdTotalProdutos;

    public Loja(string nomeLoja, int qtdTotalProdutos)
    {
        this.nomeLoja = nomeLoja;
        this.estoque = new Produto[qtdTotalProdutos];
        this.qtdTotalProdutos = 0;
    }

    public Produto AdicionarProduto(string nome, int unidades, double valor)
    {
        if (qtdTotalProdutos == estoque.Length)
        {
            throw new IndexOutOfRangeException("O estoque já está cheio");
        }

        estoque[qtdTotalProdutos] = new Produto(nome, unidades, valor);
        qtdTotalProdutos++;
        return estoque[qtdTotalProdutos - 1];
    }

    public void ListarProdutos()
    {
        if (qtdTotalProdutos == 0)
        {
            throw new IndexOutOfRangeException("O estoque está vazio");
        }

        for (var i = 0; i < qtdTotalProdutos; i++)
        {
            Console.WriteLine($"Nome: {estoque[i].Nome}\n" +
                              $"Unidades: {estoque[i].Unidades}\n" +
                              $"Valor: {estoque[i].Valor.ToString("C",new CultureInfo("en-us"))}");
            Console.WriteLine("--------Console--------");

        }
    }

    public Produto EditarProduto(string nome, int unidades, double valor)
    {
        if (qtdTotalProdutos == 0)
        {
            throw new IndexOutOfRangeException("O estoque está vazio");
        }

        for (var i = 0; i < qtdTotalProdutos; i++)
        {
            if (estoque[i].Nome == nome)
            {
                // estoque[i].Unidades = unidades;
                // estoque[i].Valor = valor;
                estoque[i] = new Produto(nome, unidades, valor);
                return estoque[i];
            }
        }

        throw new Exception("Não existe este produto no estoque");
    }
    
}