using Microsoft.AspNetCore.Mvc;

namespace aspnet_demo_api.Controllers
{
    [ApiController]
    [Route("api/health")]
    public class HealthController : Controller
    {

        public HealthController()
        {
        }

        [HttpGet()]
        public IActionResult Get()
        {
            return Ok("Application Online");
        }
    }
}
