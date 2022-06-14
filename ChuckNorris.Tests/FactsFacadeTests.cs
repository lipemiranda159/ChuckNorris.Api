using ChuckNorris.Facades;
using ChuckNorris.Models;
using ChuckNorris.Services;
using NSubstitute;
using System.Threading.Tasks;
using Xunit;

namespace ChuckNorris.Tests
{
    public class FactsFacadeTests
    {
        private readonly IChuckNorrisApiService _chuckNorrisApiService;
        public FactsFacadeTests()
        {
            _chuckNorrisApiService = Substitute.For<IChuckNorrisApiService>();
        }

        [Fact]
        public async Task GetFactsTest()
        {
            _chuckNorrisApiService.GetJokesAsync().Returns(new JokesResponse() { value = "Chuck Norris can chuck more wood than a woodchuck could." });
            var factsFacade = new FactsFacade(_chuckNorrisApiService);
            var facts = await factsFacade.GetFactsAsync(1);
            Assert.Equal("CH. Norris can chuck more wood than a woodchuck could.", facts[1]);
        }

    }
}
