namespace projeto_estoque;

public class Produto
{
    private readonly string nome;
    private int unidades;
    private double valor;
    /// <summary>
    /// Classe sempre terá o mesmo nome que o constructor
    /// </summary>
    /// <param name="nome"></param>
    /// <param name="unidades"></param>
    /// <param name="valor"></param>
    public Produto(string nome, int unidades, double valor)
    {
        this.nome = nome;
        this.unidades = unidades;
        this.valor = valor;
    }
    /// <summary>
    /// Get e set são usados para proteger a informação, observar as regras de negócio
    /// </summary>
    public int Unidades
    {
        get => unidades;
        set => unidades = value;
    }

    public double Valor
    {
        get => valor;
        set => valor = value;
    }

    public string Nome => nome;
}