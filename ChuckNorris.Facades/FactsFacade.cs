using ChuckNorris.Facades.Interfaces;
using ChuckNorris.Models.Extensions;
using ChuckNorris.Services;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace ChuckNorris.Facades
{
    public class FactsFacade : IFactsFacade
    {
        private readonly IChuckNorrisApiService _chuckNorrisApiService;
        public FactsFacade(IChuckNorrisApiService chuckNorrisApiService)
        {
            _chuckNorrisApiService = chuckNorrisApiService;
        }
        public async Task<List<string>> GetFactsAsync(int count)
        {
            var result = new List<string>();
            for (int i = 0; i < count; i++)
            {
                var facts = await _chuckNorrisApiService.GetJokesAsync();
                result.Add(facts.ToJoke());
            }
            return result;
        }
    }
}
