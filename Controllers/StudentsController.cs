using Microsoft.AspNetCore.Mvc;
using Registrar.Models;

namespace NameRegistrar.Controllers;

[ApiController]
[Route("api/[controller]")]
public class StudentsController : ControllerBase
{

    private readonly RegistrarContext _db;

    public StudentsController(RegistrarContext context)
    {
        _db = context;
    }

    [HttpGet]
    public IActionResult Get()
    {
        return Ok(_db.Students.ToList());
    }

    [HttpGet("{id}")]
    public IActionResult Get(int id)
    {
        var thisStudent = _db.Students.FirstOrDefault(student => student.Id == id);
        return Ok(thisStudent);
    }

    //Get address for a student by id
    [HttpGet("{id}/address")]
    public IActionResult GetAddress(int id)
    {
        var student = _db.Students.FirstOrDefault(student => student.Id == id);
        if (student == null)
        {
            return NotFound();
        }

        return Ok(student.PrimaryAddress);
    }

    //Get courses for a student by id
    [HttpGet("{id}/courses")]
    public IActionResult GetCourses(int id)
    {
        var course = from c in _db.Courses
                     join s in _db.Students on c.Id equals s.Id
                     where s.Id == id
                     select c;

        return Ok(course.ToList());
    }
}