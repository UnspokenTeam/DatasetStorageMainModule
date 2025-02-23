using Microsoft.AspNetCore.Mvc;

namespace DatasetStorage.Controllers;

[ApiController]
[Route("[controller]")]
public class TestController : ControllerBase
{
    [HttpGet("/test")]
    public string Test() => "Test";
}