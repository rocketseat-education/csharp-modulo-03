using Microsoft.AspNetCore.Mvc;

namespace MyFirstApi.Controllers;

[Route("api/[controller]")]
[ApiController]
public class UserController : ControllerBase
{
    [HttpGet]
    [ProducesResponseType(typeof(Response), StatusCodes.Status200OK)]
    [ProducesResponseType(typeof(string), StatusCodes.Status400BadRequest)]
    public IActionResult Get()
    {
        var response = new Response
        {
            Age = 7,
            Name = "welisson"
        };

        return Ok(response);
    }
}
