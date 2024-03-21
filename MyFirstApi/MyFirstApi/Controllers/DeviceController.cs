namespace MyFirstApi.Controllers;

using Microsoft.AspNetCore.Mvc;
using MyFirstApi.Entities;

public class DeviceController : MyFirstApiBaseController
{
    [HttpGet]
    public IActionResult Get()
    {
        var laptop = new Laptop();

        var model = laptop.GetBrand();

        return Ok(model);
    }
}
