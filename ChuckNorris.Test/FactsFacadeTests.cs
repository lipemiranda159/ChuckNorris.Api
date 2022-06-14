using ChuckNorris.Facades;
using ChuckNorris.Models;
using ChuckNorris.Services;
using NSubstitute;

namespace ChuckNorris.Test
{
    public class FactsFacadeTests
    {
        private readonly IChuckNorrisApiService _chuckNorrisApiService;
        public FactsFacadeTests()
        {
            _chuckNorrisApiService = Substitute.For<IChuckNorrisApiService>();
        }

        [Fact]
        public async Task GetFactsValidateReplace()
        {
            _chuckNorrisApiService.GetJokesAsync().Returns(new JokesResponse() { value = "Chuck Norris can chuck more wood than a woodchuck could." });
            var factsFacade = new FactsFacade(_chuckNorrisApiService);
            var facts = await factsFacade.GetFactsAsync(1);
            Assert.Equal("CH. Norris can chuck more wood than a woodchuck could.", facts[0]);
        }
        
        [Fact]
        public async Task GetFactsValidateCount()
        {
            _chuckNorrisApiService.GetJokesAsync().Returns(new JokesResponse() { value = "Chuck Norris can chuck more wood than a woodchuck could." });
            var factsFacade = new FactsFacade(_chuckNorrisApiService);
            var facts = await factsFacade.GetFactsAsync(2);
            Assert.True(facts.Count() == 2);

        }

    }
}