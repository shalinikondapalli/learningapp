namespace learningapp.Models
{
    public class CourseModel
    {
        public int ID { get; set; }
        public int CourseCategoryID { get; set; }
        public string CourseTitle { get; set; } = default!;
        public string CourseDescription { get; set; } = default!;
        public string CourseCode { get; set; } = default!;
        public int Credits { get; set; }
        public bool HasPrerequisites { get; set; }
        public DateTime ModifiedDate { get; set; }
    }

    public class FacultyModel
    {
        public int ID { get; set; }
        public string FirstName { get; set; } = default!;
        public string LastName { get; set; } = default!;
        public string Email { get; set; } = default!;
        public string PhoneNumber { get; set; } = default!;

        public string Department { get; set; } = default!;
        public string Title { get; set; } = default!;
        public DateTime ModifiedDate { get; set; }
        public List<CourseModel> Courses { get; set; } = new List<CourseModel>();
    }
   
}
