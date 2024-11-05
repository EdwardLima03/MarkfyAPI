using Markfy.Models;
using Markfy.Repositories;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Markfy.Services
{
    public class ProdutoService : IProdutoService
    {
        private readonly IProdutoRepository _produtoRepository;

        public ProdutoService(IProdutoRepository produtoRepository)
        {
            _produtoRepository = produtoRepository;
        }

        public async Task<IEnumerable<Produto>> GetAllProdutosAsync()
        {
            return await _produtoRepository.GetAllProdutoAsync();
        }

        public async Task<Produto> GetProdutoByIdAsync(long id)
        {
            return await _produtoRepository.GetProdutoByIdAsync(id);
        }

        public async Task AddProdutoAsync(Produto produto)
        {
            
            await _produtoRepository.AddProdutoAsync(produto);
        }

        public async Task UpdateProdutoAsync(Produto produto)
        {
            
            await _produtoRepository.UpdateProdutoAsync(produto);
        }

        public async Task DeleteProdutoAsync(long id)
        {
            
            await _produtoRepository.DeleteProdutoAsync(id);
        }

        Task<ProdutoIA> IProdutoService.GetProdutoByIdAsync(long id)
        {
            throw new NotImplementedException();
        }
    }
}
