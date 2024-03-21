namespace MyFirstApi.Controllers;

using Microsoft.AspNetCore.Mvc;

public class DeviceController : MyFirstApiBaseController
{
    [HttpGet]
    public IActionResult Get()
    {
        Autor = "maria";

        return Ok(Autor);
    }
}
