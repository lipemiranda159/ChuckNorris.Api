using Microsoft.AspNetCore.Mvc;

namespace ChuckNorris.Api.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class chuckNorrisController : ControllerBase
    {
        [HttpGet(Name = "get-facts")]
        public IActionResult GET_FACTS(int count)
        {
            var jokeList = new List<string>();

            for (int i = 0; i < count; i++)
            {
                var httpClient = new HttpClient();
                dynamic result = httpClient.GetAsync("https://api.chucknorris.io/jokes/random").Result;

                jokeList.Add(JokeHelper.GetJoke(result.value));
            }

            return this.Ok(jokeList);
        }
    }
}
