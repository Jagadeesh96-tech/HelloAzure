using Microsoft.AspNetCore.Mvc;

namespace HelloAzureApi.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class HelloController : ControllerBase
    {
        [HttpGet]
        public IActionResult Get()
        {
            return Ok("Hello Jagadeesh from Azure CI/CD API 🚀");
        }

        [HttpGet("health")]
        public IActionResult Health()
        {
            return Ok("API is running fine ✅");
        }
    }
}