using Microsoft.AspNetCore.Mvc;
using Markfy.Models;
using Markfy.Services;
using System.Collections.Generic;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization;

namespace Markfy.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    [Authorize]
    public class LojaController : ControllerBase
    {
        private readonly ILojaService _lojaService;

        public LojaController(ILojaService lojaService)
        {
            _lojaService = lojaService;
        }

        [HttpGet]
        [Authorize]
        public async Task<ActionResult<IEnumerable<Loja>>> GetLojas()
        {
            return Ok(await _lojaService.GetAllLojasAsync());
        }

        [HttpGet("{id}")]
        [Authorize]
        public async Task<ActionResult<Loja>> GetLoja(long id)
        {
            var loja = await _lojaService.GetLojaByIdAsync(id);
            if (loja == null)
            {
                return NotFound();
            }
            return Ok(loja);
        }

        [HttpPost]
        [Authorize]
        public async Task<ActionResult<Loja>> PostLoja(Loja loja)
        {
            await _lojaService.AddLojaAsync(loja);
            return CreatedAtAction(nameof(GetLoja), new { id = loja.IdLoja }, loja);
        }

        [HttpPut("{id}")]
        [Authorize]
        public async Task<IActionResult> PutLoja(long id, Loja loja)
        {
            if (id != loja.IdLoja)
            {
                return BadRequest();
            }
            await _lojaService.UpdateLojaAsync(loja);
            return NoContent();
        }

        [HttpDelete("{id}")]
        [Authorize]
        public async Task<IActionResult> DeleteLoja(long id)
        {
            await _lojaService.DeleteLojaAsync(id);
            return NoContent();
        }
    }
}
