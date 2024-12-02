using MeuSistema.Models;
using Microsoft.EntityFrameworkCore;

namespace MeuSistema.Data
{
    public class FornecedorRepository : IRepository<Fornecedor>
    {
        private readonly ApplicationDbContext _context;

        public FornecedorRepository(ApplicationDbContext context)
        {
            _context = context;
        }

        // Obter todos os fornecedores
        public async Task<IEnumerable<Fornecedor>> GetAllAsync()
        {
            return await _context.Fornecedores.ToListAsync();
        }

        // Obter um fornecedor específico pelo Id
        public async Task<Fornecedor> GetByIdAsync(int id)
        {
            return await _context.Fornecedores.FindAsync(id);
        }

        // Adicionar um novo fornecedor
        public async Task AddAsync(Fornecedor fornecedor)
        {
            await _context.Fornecedores.AddAsync(fornecedor);
            await _context.SaveChangesAsync();
        }

        // Atualizar um fornecedor existente
        public async Task UpdateAsync(Fornecedor fornecedor)
        {
            _context.Fornecedores.Update(fornecedor);
            await _context.SaveChangesAsync();
        }

        // Remover um fornecedor
        public async Task DeleteAsync(int id)
        {
            var fornecedor = await _context.Fornecedores.FindAsync(id);
            if (fornecedor != null)
            {
                _context.Fornecedores.Remove(fornecedor);
                await _context.SaveChangesAsync();
            }
        }
    }
}
