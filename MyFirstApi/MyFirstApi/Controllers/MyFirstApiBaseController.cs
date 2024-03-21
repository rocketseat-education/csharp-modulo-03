using Microsoft.AspNetCore.Mvc;

namespace MyFirstApi.Controllers;

[Route("api/[controller]")]
[ApiController]
public class MyFirstApiBaseController : ControllerBase
{
    public string Autor { get; set; } = "Welisson Arley";

    [HttpGet("heathy")]
    public IActionResult Heathy()
    {
        return Ok("It`s working");
    }

    public string GetCustomKey()
    {
        return Request.Headers["MyKey"].ToString();
    }
}
