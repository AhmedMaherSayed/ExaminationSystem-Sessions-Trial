namespace ExaminationSystem_Sessions_Trial.Models
{
    public class Instructor
    {

        public Instructor()
        {
            InstructorCourses = new HashSet<InstructorCourse>();
        }

        public int ID { get; set; }
        public string Name { get; set; }
        public string Mobile { get; set; }

        public ICollection<InstructorCourse> InstructorCourses { get; set; }
    }
}
