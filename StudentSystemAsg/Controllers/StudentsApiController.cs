using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using StudentSystemAsg.Models;
using StudentSystemAsg.Service_Layer;

namespace StudentSystemAsg.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class StudentsApiController : ControllerBase
    {
        private readonly StudentService _service;

        public StudentsApiController(StudentService service)
        {
            _service = service;
        }

        [HttpGet]
        public async Task<IActionResult> GetAll()
            => Ok(await _service.GetAll());

        [HttpGet("{id}")]
        public async Task<IActionResult> Get(int id)
            => Ok(await _service.GetById(id));

        [HttpPost]
        public async Task<IActionResult> Create(Student student)
        {
            await _service.Add(student);
            return Ok("Created");
        }

        [HttpPut("{id}")]
        public async Task<IActionResult> Update(int id, Student student)
        {
            await _service.Update(id, student);
            return Ok("Updated");
        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> Delete(int id)
        {
            await _service.Delete(id);
            return Ok("Deleted");
        }
    }
}
