using Microsoft.AspNetCore.Mvc;
using Models;

namespace Pizzaria.Controllers
{
    [ApiController]
    [Route("environment")]
    public class EnvironmentController : ControllerBase
    {
        [HttpGet]
        [Route("neighborhood")]
        public ActionResult GetNeighborhood()
        {
            return Ok(
                AvailablesNeighborhood.Neighborhood
                );
        }
    }
}
