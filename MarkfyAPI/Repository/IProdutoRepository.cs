using Markfy.Models;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Markfy.Repositories
{
    public interface IProdutoRepository
    {
        Task<IEnumerable<Produto>> GetAllProdutoAsync();
        Task<Produto> GetProdutoByIdAsync(long id);
        Task AddProdutoAsync(Produto produto);
        Task UpdateProdutoAsync(Produto produto);
        Task DeleteProdutoAsync(long id);
    }
}
