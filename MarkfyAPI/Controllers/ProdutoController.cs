using Microsoft.AspNetCore.Mvc;
using Markfy.Models;
using Markfy.Services;
using System.Collections.Generic;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization;

namespace Markfy.Controllers
{
    [Authorize]
    [Route("api/[controller]")]
    [ApiController]
    public class ProdutoController : ControllerBase
    {
        private readonly IProdutoService _produtoService;

        public ProdutoController(IProdutoService produtoService)
        {
            _produtoService = produtoService;
        }

        
        [HttpGet]
        public async Task<ActionResult<IEnumerable<ProdutoIA>>> GetProdutos()
        {
            var produtos = await _produtoService.GetAllProdutosAsync();
            return Ok(produtos);
        }

        
        [HttpGet("{id}")]
        public async Task<ActionResult<ProdutoIA>> GetProduto(long id)
        {
            var produto = await _produtoService.GetProdutoByIdAsync(id);
            if (produto == null)
            {
                return NotFound();
            }
            return Ok(produto);
        }

        
        [HttpPost]
        public async Task<ActionResult<Produto>> PostProduto(Produto produto)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            await _produtoService.AddProdutoAsync(produto);

            return CreatedAtAction(nameof(GetProduto), new { id = produto.Id }, produto);
        }

        
        [HttpPut("{id}")]
        public async Task<IActionResult> PutProduto(long id, Produto produto)
        {
            if (id != produto.Id)
            {
                return BadRequest();
            }

            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            try
            {
                await _produtoService.UpdateProdutoAsync(produto);
            }
            catch (KeyNotFoundException)
            {
                return NotFound();
            }

            return NoContent();
        }

        
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteProduto(long id)
        {
            try
            {
                await _produtoService.DeleteProdutoAsync(id);
            }
            catch (KeyNotFoundException)
            {
                return NotFound();
            }

            return NoContent();
        }
    }
}
