using BlogApi.Atributes;
using Microsoft.AspNetCore.Mvc;

//Health Check
namespace BlogApi.Controllers
{
    [ApiController]
    [Route("")]
    public class HomeController : ControllerBase
    {
        [HttpGet("")]
        [ApiKey]
        public IActionResult Get()
        {
            return Ok("teste");
        }
    }
}
