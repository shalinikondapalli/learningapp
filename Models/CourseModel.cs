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
}
