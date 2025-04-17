using learningapp.Models;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace learningapp.Pages.ProfileManagement.Faculty
{
    public class DashboardModel : PageModel
    {
        public FacultyModel FacultyProfile { get; set; } = new FacultyModel();

        public void OnGet()
        {
            LoadProfile();
        }

        private void LoadProfile()
        {
            FacultyProfile = new FacultyModel {
                FirstName = "John",
                LastName = "Doe",
                Email = "John.Doe@LeanProg.com",
                PhoneNumber = "123-456-7890",
                Department="Computer Science and Engineering",
                Title = "Professor",
                Courses = new List<CourseModel>
                {
                    new CourseModel
                    {
                        ID = 1,
                        CourseTitle = "Introduction to Programming",
                        CourseDescription = "Learn the basics of programming.",
                        CourseCode = "CS101",
                        Credits = 3,
                        HasPrerequisites = false,
                        ModifiedDate = DateTime.Now
                    },
                    new CourseModel
                    {
                        ID = 2,
                        CourseTitle = "Advanced Programming",
                        CourseDescription = "Deep dive into advanced programming concepts.",
                        CourseCode = "CS201",
                        Credits = 4,
                        HasPrerequisites = true,
                        ModifiedDate = DateTime.Now
                    }
                }
            };
        }
    }
}
