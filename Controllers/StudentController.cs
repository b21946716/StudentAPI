using Microsoft.AspNetCore.Mvc;
using StudentAPI2.Model;
using StudentAPI2.Repository;
using System.Collections.Generic;

namespace StudentAPI2.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class StudentController : ControllerBase
    {
        ApplicationDbContext _database;
        private readonly StudentRepository _studentRepository;
        public StudentController(ApplicationDbContext database)
        {
            _database = database;
            _studentRepository = new StudentRepository(_database);
        }

        [HttpGet]

        public ActionResult<List<Student>> GetAllStudent()
        {

            List<Student> students1 = _studentRepository.GetAllStudents();
            return new ActionResult<List<Student>>(students1);
        }
       
        [HttpGet("{id}")]
        public ActionResult<Student> GetEmployee(int id)
        {
            var student = _studentRepository.GetStudent(id);
            if (student == null)
            {
                return NotFound();
            }
            return Ok(student);
        }
    }
}
