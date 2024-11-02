namespace ExaminationSystem_Sessions_Trial.Models
{
    public class InstructorCourse
    {
        public int ID { get; set; }

        public int InstructorID { get; set; }
        public Instructor Instructor { get; set; }

        public int CourseID { get; set; }
        public Course CouresID { get; set; }
    }
}
