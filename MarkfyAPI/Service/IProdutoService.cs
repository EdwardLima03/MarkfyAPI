using Markfy.Models;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Markfy.Services
{
    public interface IProdutoService
    {
        Task<IEnumerable<Produto>> GetAllProdutosAsync();
        Task<ProdutoIA> GetProdutoByIdAsync(long id);
        Task AddProdutoAsync(Produto produto);
        Task UpdateProdutoAsync(Produto produto);
        Task DeleteProdutoAsync(long id);
    }
}
