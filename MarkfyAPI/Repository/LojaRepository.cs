using Microsoft.EntityFrameworkCore;
using Markfy.Models;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Markfy.Repositories
{
    public class LojaRepository : ILojaRepository
    {
        private readonly Contexto _context;

        public LojaRepository(Contexto context)
        {
            _context = context;
        }

        public async Task<IEnumerable<Loja>> GetAllLojasAsync()
        {
            return await _context.Loja.ToListAsync();
        }

        public async Task<Loja> GetLojaByIdAsync(long id)
        {
            return await _context.Loja.FindAsync(id);
        }

        public async Task AddLojaAsync(Loja loja)
        {
            _context.Loja.Add(loja);
            await _context.SaveChangesAsync();
        }

        public async Task UpdateLojaAsync(Loja loja)
        {
            _context.Entry(loja).State = EntityState.Modified;
            await _context.SaveChangesAsync();
        }

        public async Task DeleteLojaAsync(long id)
        {
            var loja = await _context.Loja.FindAsync(id);
            if (loja != null)
            {
                _context.Loja.Remove(loja);
                await _context.SaveChangesAsync();
            }
        }
    }
}
