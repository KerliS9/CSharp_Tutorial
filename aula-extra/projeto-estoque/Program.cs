namespace projeto_estoque;

public class Program
{
    public static void Main()
    {
        // var loja = new Loja("Fiasco", 10);
        // loja.AdicionarProduto("Havaiana", 10, 20.50);
        // loja.ListarProdutos();
        // loja.EditarProduto("Havaiana", 9, 20.50);
        // loja.ListarProdutos();

        Console.WriteLine("Digite o nome da sua loja: ");
        string nomeLoja = Console.ReadLine();
        Console.WriteLine("Digite a quantidade disponível no estoque: ");
        int qtdTotal = Convert.ToInt32(Console.ReadLine());
        // var qtdTotal = Console.ReadLine();
        var loja1 = new Loja(nomeLoja, qtdTotal);

        Console.WriteLine("Digite o nome do produto: ");
        string produto = Console.ReadLine();
        Console.WriteLine("Digite as unidades disponíveis deste produto: ");
        int unidades = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Digite o preço deste produto: ");
        double valor = Convert.ToDouble(Console.ReadLine());

        loja1.AdicionarProduto(produto, unidades, valor);
        loja1.ListarProdutos();
        loja1.EditarProduto(produto, unidades, valor);
        // loja1.ListarProdutos();
    }
}

