using Markfy.Models;
using Markfy.Repositories;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Markfy.Services
{
    public class LojaService : ILojaService
    {
        private readonly ILojaRepository _lojaRepository;

        public LojaService(ILojaRepository lojaRepository)
        {
            _lojaRepository = lojaRepository;
        }

        public async Task<IEnumerable<Loja>> GetAllLojasAsync()
        {
            return await _lojaRepository.GetAllLojasAsync();
        }

        public async Task<Loja> GetLojaByIdAsync(long id)
        {
            return await _lojaRepository.GetLojaByIdAsync(id);
        }

        public async Task AddLojaAsync(Loja loja)
        {
            
            await _lojaRepository.AddLojaAsync(loja);
        }

        public async Task UpdateLojaAsync(Loja loja)
        {
           
            await _lojaRepository.UpdateLojaAsync(loja);
        }

        public async Task DeleteLojaAsync(long id)
        {
            await _lojaRepository.DeleteLojaAsync(id);
        }
    }
}
