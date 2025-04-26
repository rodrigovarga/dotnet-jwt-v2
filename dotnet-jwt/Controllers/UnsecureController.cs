using Microsoft.AspNetCore.Mvc;

namespace dotnet_jwt.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class UnsecureController : ControllerBase
    {
        [HttpGet("ping")]
        public IActionResult Ping()
        {
            return Ok("Pong");
        }
    }
}