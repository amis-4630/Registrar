using Microsoft.AspNetCore.Mvc;

namespace NameRegistrar.Controllers;

[ApiController]
[Route("api/[controller]")]
public class StudentsController : ControllerBase
{
    [HttpGet]
    public IActionResult Get()
    {
        return Ok(new[] { "John", "Jane", "Joe" });
    }
}