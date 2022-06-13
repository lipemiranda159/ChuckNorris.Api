using ChuckNorris.Models;
using RestEase;
using System.Threading.Tasks;

namespace ChuckNorris.Services
{
    public interface IChuckNorrisApiService
    {
        [Get("/jokes/random")]
        Task<JokesResponse> GetJokesAsync();
    }
}
