public class ProdutoIA
{
    public string ProdutoId { get; set; }
    public string Nome { get; set; }
    public string Categoria { get; set; }
    public float Preco { get; set; }
}

public class ProdutoRecommendation
{
    public string ProdutoId { get; set; }
    public float Score { get; set; }
}
