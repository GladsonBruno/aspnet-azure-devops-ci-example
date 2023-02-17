using aspnet_demo_api.Entity;
using aspnet_demo_api.Interface;
using Microsoft.AspNetCore.Mvc;

namespace aspnet_demo_api.Controllers
{
    [ApiController]
    [Route("api/users")]
    public class UserController : Controller
    {

        private readonly IUserRepository userRepository;

        public UserController(IUserRepository userRepository)
        {
            this.userRepository = userRepository;
        }

        [HttpGet()]
        public IActionResult Get()
        {
            List<User> users = this.userRepository.GetAll();

            return Ok(users);
        }

        [HttpGet("{id}")]
        public IActionResult Get(int id)
        {

            User? user = this.userRepository.GetById(id);

            if (user != null)
            {
                
                return Ok(user);

            } else
            {
                
                return NoContent();

            }

        }

    }
}
