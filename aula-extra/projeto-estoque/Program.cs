namespace projeto_estoque;

public class Program
{
    public static void Main()
    {
        var loja = new Loja("Fiasco", 10);
        loja.AdicionarProduto("Havaiana", 10, 20.50);
        loja.ListarProdutos();
        loja.EditarProduto("Havaiana", 9, 20.50);
        loja.ListarProdutos();
    }
}

