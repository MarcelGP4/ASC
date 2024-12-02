using MeuSistema.Models;
using MeuSistema.Services;
using Microsoft.AspNetCore.Mvc;

namespace MeuSistema.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PedidosController : ControllerBase
    {
        private readonly PedidoService _pedidoService;

        public PedidosController(PedidoService pedidoService)
        {
            _pedidoService = pedidoService;
        }

        [HttpGet]
        public async Task<ActionResult<IEnumerable<Pedido>>> GetPedidos()
        {
            var pedidos = await _pedidoService.GetPedidosAsync();
            return Ok(pedidos);
        }

        [HttpGet("{id}")]
        public async Task<ActionResult<Pedido>> GetPedido(int id)
        {
            var pedido = await _pedidoService.GetPedidoByIdAsync(id);
            if (pedido == null)
            {
                return NotFound();
            }
            return Ok(pedido);
        }

        [HttpPost]
        public async Task<ActionResult> PostPedido(Pedido pedido)
        {
            await _pedidoService.AddPedidoAsync(pedido);
            return CreatedAtAction(nameof(GetPedido), new { id = pedido.Id }, pedido);
        }

        [HttpPut("{id}")]
        public async Task<ActionResult> PutPedido(int id, Pedido pedido)
        {
            if (id != pedido.Id)
            {
                return BadRequest();
            }
            await _pedidoService.UpdatePedidoAsync(pedido);
            return NoContent();
        }

        [HttpDelete("{id}")]
        public async Task<ActionResult> DeletePedido(int id)
        {
            await _pedidoService.DeletePedidoAsync(id);
            return NoContent();
        }
    }
}
