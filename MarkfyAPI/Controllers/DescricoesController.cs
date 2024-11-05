using Microsoft.AspNetCore.Mvc;

[Route("api/[controller]")]
[ApiController]
public class DescricoesController : ControllerBase
{
    private readonly GeracaoTextoService _geracaoTextoService;

    public DescricoesController(GeracaoTextoService geracaoTextoService)
    {
        _geracaoTextoService = geracaoTextoService;
    }

    [HttpGet("descricao/{nomeProduto}/{categoria}")]
    public ActionResult<string> GerarDescricao(string nomeProduto, string categoria)
    {
        var descricao = _geracaoTextoService.GerarDescricaoProduto(nomeProduto, categoria);
        return Ok(descricao);
    }
}
