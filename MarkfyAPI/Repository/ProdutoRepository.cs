using Microsoft.EntityFrameworkCore;
using Markfy.Models;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Markfy.Repositories
{
    public class ProdutoRepository : IProdutoRepository
    {
        private readonly Contexto _context;

        public ProdutoRepository(Contexto context)
        {
            _context = context;
        }

        public async Task<IEnumerable<Produto>> GetAllProdutoAsync()
        {
            return await _context.Produto.ToListAsync();
        }

        public async Task<Produto> GetProdutoByIdAsync(long id)
        {
            return await _context.Produto.FindAsync(id);
        }

        public async Task AddProdutoAsync(Produto produto)
        {
            _context.Produto.Add(produto);
            await _context.SaveChangesAsync();
        }

        public async Task UpdateProdutoAsync(Produto produto)
        {
            _context.Entry(produto).State = EntityState.Modified;
            await _context.SaveChangesAsync();
        }

        public async Task DeleteProdutoAsync(long id)
        {
            var produto = await _context.Produto.FindAsync(id);
            if (produto != null)
            {
                _context.Produto.Remove(produto);
                await _context.SaveChangesAsync();
            }
        }
    }
}
