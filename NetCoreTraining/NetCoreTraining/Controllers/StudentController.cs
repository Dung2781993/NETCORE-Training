using Domain.Interfaces;
using Microsoft.AspNetCore.Mvc;
using NetCoreTraining.Models;

namespace NetCoreTraining.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class StudentController : ControllerBase
    {
        private readonly IUnitOfWork _unitOfWork;
        public StudentController(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }

        //GET: api/Students
        [HttpGet]
        public IActionResult GetStudents()
        {
            var students =  _unitOfWork.Student.GetAll().ToList();
            Console.WriteLine(students);
            return null;
        }
    }
}
