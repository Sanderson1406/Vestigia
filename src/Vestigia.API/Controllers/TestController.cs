using Microsoft.AspNetCore.Mvc;

namespace Vestigia.API.Controllers;

[ApiController]
[Route("api/test")]
public class TestController : ControllerBase
{
    [HttpGet]
    public IActionResult Get()
    {
        return Ok("Swagger funcionando!");
    }
}
