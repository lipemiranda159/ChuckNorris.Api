using System.Collections.Generic;
using System.Threading.Tasks;

namespace ChuckNorris.Facades.Interfaces
{
    public interface IFactsFacade
    {
        Task<List<string>> GetFactsAsync();
    }
}
