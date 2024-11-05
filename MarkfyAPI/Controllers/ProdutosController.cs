using Microsoft.AspNetCore.Mvc;

[Route("api/[controller]")]
[ApiController]
public class ProdutosController : ControllerBase
{
    private readonly RecomendacaoService _recomendacaoService;

    public ProdutosController(RecomendacaoService recomendacaoService)
    {
        _recomendacaoService = recomendacaoService;
    }

    // Exemplo de endpoint que retorna recomendações de produtos
    [HttpGet("recomendacoes/{produtoId}")]
    public ActionResult<List<ProdutoRecommendation>> GetRecomendacoes(string produtoId)
    {
        var recomendacoes = _recomendacaoService.ObterRecomendacoes(produtoId);
        return Ok(recomendacoes);
    }
}
