using ExaminationSystem_Sessions_Trial.Data;
using ExaminationSystem_Sessions_Trial.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace ExaminationSystem_Sessions_Trial.Controllers
{
    [Route("[controller]/[action]")]
    [ApiController]
    public class InstructorController : ControllerBase
    {
        private readonly ApplicationDbContext _context;

        public InstructorController(ApplicationDbContext context)
        {
            _context = context;
        }
        [HttpPost]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        public async Task<IActionResult> Create(Instructor instructor)
        {
            if (instructor is not null)
            {
                await _context.Instructors.AddAsync(instructor);
                await _context.SaveChangesAsync();
                return Ok();
            }
           return BadRequest();
        }

        [HttpGet]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        public async Task<IActionResult> Get(string name)
        {
            //var instructor = GetAllInstructors().Where(ins => ins.Name.Contains(name)).FirstOrDefault();
            
            var instructor = await _context.Instructors
                .Where(ins => ins.Name.Contains(name))
                .FirstOrDefaultAsync();


            if (instructor is not null)
                return Ok(instructor);

            return NotFound();
        }

        private IEnumerable<Instructor> GetAllInstructors()
            => _context.Instructors;
    }
}
