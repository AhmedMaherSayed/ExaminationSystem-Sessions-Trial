using ExaminationSystem_Sessions_Trial.Models;
using Microsoft.EntityFrameworkCore;

namespace ExaminationSystem_Sessions_Trial.Data
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
        {
            
        }

        public DbSet<Instructor> Instructors { get; set; }
        public DbSet<Course> Courses { get; set; }
        public DbSet<InstructorCourse> InstructorCourses { get; set; }
    }
}
