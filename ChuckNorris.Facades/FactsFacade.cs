using ChuckNorris.Facades.Interfaces;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace ChuckNorris.Facades
{
    public class FactsFacade : IFactsFacade
    {
        public Task<List<string>> GetFactsAsync()
        {
            throw new System.NotImplementedException();
        }
    }
}
