using System.Collections.Generic;
using System.Threading.Tasks;
using API.Entities;
using API.Interfaces;
using API.ViewModels;
using Microsoft.AspNetCore.Mvc;


namespace API.Controllers
{
    [ApiController]
    [Route("api/students")]
    public class StudentsController : ControllerBase
    {
        private readonly IUnitOfWork _unitOfWork;

        public StudentsController(IUnitOfWork unitOfWork)
        {

            _unitOfWork = unitOfWork;
        }

        [HttpGet]
        public async Task<ActionResult<IEnumerable<Student>>> GetStudents(){
            return Ok(await _unitOfWork.StudentRepository.GetStudentsAsync());
        }

        [HttpPost()]
        public async Task<ActionResult> AddStudentToCourse(StudentViewModel model){
            var user = await _unitOfWork.UserRepository.GetUserByIdAsync(model.UserId);
            if(user == null) return BadRequest($"Användaren med id {model.UserId} finns inte i systemet.");

            var course = await _unitOfWork.CourseRepository.GetCourseByIdAsync(model.CourseId);
            if(course == null) return BadRequest($"Kursen med id {model.CourseId} finns inte i systemet.");

            _unitOfWork.StudentRepository.Add(model);

            if (await _unitOfWork.Complete())
            {
                return StatusCode(201);
            }

            return StatusCode(500, "Err.Användaren har inte sparat");
        }
    }
}