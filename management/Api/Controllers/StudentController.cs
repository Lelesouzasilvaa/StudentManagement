using management.Application.Services;
using management.Domain.Entities;
using Microsoft.AspNetCore.Mvc;

namespace management.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class StudentController : ControllerBase
    {
        private readonly StudentService _studentService;

        public StudentController(StudentService studentService)
        {
            _studentService = studentService;
        }

        [HttpPost]
        public async Task<ActionResult<Student>> Enroll(Student student)
        {
            var result = await _studentService.Enrrol(student);
            return Ok(result);
        }

        [HttpGet]
        public async Task<ActionResult<List<Student>>> GetAll()
        {
            var result = await _studentService.ListingStudent();
            return Ok(result);
        }
    }
}