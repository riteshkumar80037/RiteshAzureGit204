using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace AzureAppWepApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class StudentController : ControllerBase
    {
        List<Student> students; 
        public StudentController()
        {
            students = new List<Student>();
        }
        [HttpGet]
       public IActionResult GetStudnetData()
        {

            students.Add(new Student
            {
                Id=1,
                Class="10th",
                Name="Ritesh"

            });
            students.Add(new Student
            {
                Id = 2,
                Class = "12th",
                Name = "Priyanka"

            });
            return Ok(students);
        }
    }
}
