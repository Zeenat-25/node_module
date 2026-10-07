using Microsoft.AspNetCore.Mvc;
using StudentRESTAPI.Models;

namespace StudentRESTAPI.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class StudentController : ControllerBase
    {
        static List<Student> students = new List<Student>
        {
            new Student { Id = 1, Name = "Zeenat", Course = "BCA" },
            new Student { Id = 2, Name = "Aisha", Course = "BCA" }
        };

        [HttpGet]
        public IActionResult Get()
        {
            return Ok(students);
        }

        [HttpPost]
        public IActionResult Post(Student student)
        {
            students.Add(student);
            return Ok(student);
        }

        [HttpPut("{id}")]
        public IActionResult Put(int id, Student student)
        {
            var s = students.Find(x => x.Id == id);

            if (s == null)
                return NotFound();

            s.Name = student.Name;
            s.Course = student.Course;

            return Ok(s);
        }

        [HttpDelete("{id}")]
        public IActionResult Delete(int id)
        {
            var student = students.Find(x => x.Id == id);

            if (student == null)
                return NotFound();

            students.Remove(student);

            return Ok("Student deleted");
        }
    }
}