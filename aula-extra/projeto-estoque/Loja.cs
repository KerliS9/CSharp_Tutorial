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

    public string NomeLoja => nomeLoja;

    public int QtdTotalProdutos
    {
        get => qtdTotalProdutos;
        set => qtdTotalProdutos = value;
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
}