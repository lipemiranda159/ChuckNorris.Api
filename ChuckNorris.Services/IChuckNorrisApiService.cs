using ChuckNorris.Models;
using RestEase;
using System.Threading.Tasks;

namespace ChuckNorris.Services
{
    public interface IChuckNorrisApiService
    {
        [Get]
        Task<JokesResponse> GetJokesAsync();
    }
}
