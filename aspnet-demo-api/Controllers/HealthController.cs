using Microsoft.AspNetCore.Mvc;

namespace aspnet_demo_api.Controllers
{
    [ApiController]
    [Route("api/health")]
    public class HealthController : Controller
    {
        private readonly ILogger<HealthController> _logger;

        public HealthController(ILogger<HealthController> logger)
        {
            _logger = logger;
        }

        [HttpGet()]
        public IActionResult Get()
        {
            return Ok("Application Online");
        }
    }
}
