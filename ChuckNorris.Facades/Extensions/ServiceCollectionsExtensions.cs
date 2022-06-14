using ChuckNorris.Facades.Interfaces;
using ChuckNorris.Services;
using Microsoft.Extensions.DependencyInjection;
using RestEase;

namespace ChuckNorris.Facades.Extensions
{
    public static class ServiceCollectionsExtensions
    {
        public static void AddSingletons(this IServiceCollection services)
        {
            var client = RestClient.For<IChuckNorrisApiService>("https://api.chucknorris.io");
            services.AddSingleton(client);
            services.AddSingleton<IFactsFacade, FactsFacade>();

        }
    }
}
