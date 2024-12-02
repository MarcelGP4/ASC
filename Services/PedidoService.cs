using MeuSistema.Models;
using MeuSistema.Data;

namespace MeuSistema.Services
{
    public class PedidoService
    {
        private readonly IRepository<Pedido> _pedidoRepository;

        public PedidoService(IRepository<Pedido> pedidoRepository)
        {
            _pedidoRepository = pedidoRepository;
        }

        public async Task<IEnumerable<Pedido>> GetPedidosAsync()
        {
            return await _pedidoRepository.GetAllAsync();
        }

        public async Task<Pedido> GetPedidoByIdAsync(int id)
        {
            return await _pedidoRepository.GetByIdAsync(id);
        }

        public async Task AddPedidoAsync(Pedido pedido)
        {
            await _pedidoRepository.AddAsync(pedido);
        }

        public async Task UpdatePedidoAsync(Pedido pedido)
        {
            await _pedidoRepository.UpdateAsync(pedido);
        }

        public async Task DeletePedidoAsync(int id)
        {
            await _pedidoRepository.DeleteAsync(id);
        }
    }
}
