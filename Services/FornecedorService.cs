using MeuSistema.Models;
using MeuSistema.Data;

namespace MeuSistema.Services
{
    public class FornecedorService
    {
        private readonly IRepository<Fornecedor> _fornecedorRepository;

        public FornecedorService(IRepository<Fornecedor> fornecedorRepository)
        {
            _fornecedorRepository = fornecedorRepository;
        }

        public async Task<IEnumerable<Fornecedor>> GetFornecedoresAsync()
        {
            return await _fornecedorRepository.GetAllAsync();
        }

        public async Task<Fornecedor> GetFornecedorByIdAsync(int id)
        {
            return await _fornecedorRepository.GetByIdAsync(id);
        }

        public async Task AddFornecedorAsync(Fornecedor fornecedor)
        {
            await _fornecedorRepository.AddAsync(fornecedor);
        }

        public async Task UpdateFornecedorAsync(Fornecedor fornecedor)
        {
            await _fornecedorRepository.UpdateAsync(fornecedor);
        }

        public async Task DeleteFornecedorAsync(int id)
        {
            await _fornecedorRepository.DeleteAsync(id);
        }
    }
}
