namespace ExaminationSystem_Sessions_Trial.Models
{
    public class Course
    {
        public Course()
        {
            InstructorCourses = new HashSet<InstructorCourse>();  
        }
        public int ID { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public int Hours { get; set; }

        public ICollection<InstructorCourse> InstructorCourses { get; set; }
    }
}
