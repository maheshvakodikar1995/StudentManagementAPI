using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using StudentManagementAPI.Models;
using StudentManagementAPI.Services;

namespace StudentManagementAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    [Authorize]
    public class StudentController : ControllerBase
    {
        #region Fields
        private readonly IStudentService _studentService;
        #endregion

        #region Ctor
        public StudentController(IStudentService studentService)
        {
            _studentService = studentService;
        }
        #endregion

        #region Methods
        [HttpGet]
        public async Task<IActionResult> GetAll()
        {
            return Ok(await _studentService.GetAllStudentsAsync());
        }

        [HttpPost]
        public async Task<IActionResult> Add(Student student)
        {
            await _studentService.AddStudentAsync(student);
            return Ok("Student added successfully.");
        }

        [HttpPut]
        public async Task<IActionResult> Update(Student student)
        {
            await _studentService.UpdateStudentAsync(student);
            return Ok("Student updated successfully.");
        }

        [HttpDelete]
        public async Task<IActionResult> Delete(int id)
        {
            await _studentService.DeleteStudentAsync(id);
            return Ok("Student deleted successfully.");
        }
        #endregion
    }
}
