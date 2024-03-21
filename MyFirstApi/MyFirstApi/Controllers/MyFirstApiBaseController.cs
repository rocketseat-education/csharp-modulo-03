namespace MyFirstApi.Controllers;

[Route("api/[controller]")]
[ApiController]
public class MyFirstApiBaseController : ControllerBase
{
    public string Autor { get; set; } = "Welisson Arley";
}