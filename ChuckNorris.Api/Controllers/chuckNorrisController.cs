using ChuckNorris.Facades.Interfaces;
using Microsoft.AspNetCore.Mvc;

namespace ChuckNorris.Api.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class chuckNorrisController : ControllerBase
    {
        private readonly IFactsFacade _factsFacade;
        public chuckNorrisController(IFactsFacade factsFacade)
        {
            _factsFacade = factsFacade;
        }

        /// <summary>
        /// Get facts of api
        /// </summary>
        /// <param name="count">Number of facts that will be returned</param>
        /// <returns></returns>
        [HttpGet(Name = "get-facts")]
        public async Task<IActionResult> GET_FACTS(int count)
        {
            return this.Ok(await _factsFacade.GetFactsAsync(count));
        }
    }
}
