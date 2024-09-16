using Markfy.Models;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Markfy.Repositories
{
    public interface ILojaRepository
    {
        Task<IEnumerable<Loja>> GetAllLojasAsync();
        Task<Loja> GetLojaByIdAsync(long id);
        Task AddLojaAsync(Loja loja);
        Task UpdateLojaAsync(Loja loja);
        Task DeleteLojaAsync(long id);
    }
}
