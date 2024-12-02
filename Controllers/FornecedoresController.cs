using MeuSistema.Models;
using MeuSistema.Services;
using Microsoft.AspNetCore.Mvc;

namespace MeuSistema.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class FornecedoresController : ControllerBase
    {
        private readonly FornecedorService _fornecedorService;

        public FornecedoresController(FornecedorService fornecedorService)
        {
            _fornecedorService = fornecedorService;
        }

        // GET: api/fornecedores
        [HttpGet]
        public async Task<ActionResult<IEnumerable<Fornecedor>>> GetFornecedores()
        {
            var fornecedores = await _fornecedorService.GetFornecedoresAsync();
            return Ok(fornecedores);
        }

        // GET: api/fornecedores/5
        [HttpGet("{id}")]
        public async Task<ActionResult<Fornecedor>> GetFornecedor(int id)
        {
            var fornecedor = await _fornecedorService.GetFornecedorByIdAsync(id);
            if (fornecedor == null)
            {
                return NotFound();
            }
            return Ok(fornecedor);
        }

        // POST: api/fornecedores
        [HttpPost]
        public async Task<ActionResult> PostFornecedor(Fornecedor fornecedor)
        {
            await _fornecedorService.AddFornecedorAsync(fornecedor);
            return CreatedAtAction(nameof(GetFornecedor), new { id = fornecedor.Id }, fornecedor);
        }

        // PUT: api/fornecedores/5
        [HttpPut("{id}")]
        public async Task<ActionResult> PutFornecedor(int id, Fornecedor fornecedor)
        {
            if (id != fornecedor.Id)
            {
                return BadRequest();
            }
            await _fornecedorService.UpdateFornecedorAsync(fornecedor);
            return NoContent();
        }

        // DELETE: api/fornecedores/5
        [HttpDelete("{id}")]
        public async Task<ActionResult> DeleteFornecedor(int id)
        {
            await _fornecedorService.DeleteFornecedorAsync(id);
            return NoContent();
        }
    }
}
