using learningapp.Models;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.Data.SqlClient;

namespace learningapp.Pages
{
    public class CoursesModel : PageModel
    {
        private readonly IWebHostEnvironment _hostingEnvironment;
        private readonly ILogger<CoursesModel> _logger;
        private readonly IConfiguration _configuration;
        public List<CourseModel> Courses { get; set; } = [];

        public CoursesModel(
            ILogger<CoursesModel> logger,
            IConfiguration configuration,
            IWebHostEnvironment hostingEnvironment)
        {
            _logger = logger;
            _configuration = configuration;
            _hostingEnvironment = hostingEnvironment;
        }
        public void OnGet()
        {
            try
            {
                if (_hostingEnvironment.IsDevelopment())
                {
                    Courses = [
                        new() {
                            ID = 1,
                            CourseCategoryID = 1,
                            CourseTitle = "Introduction to Programming",
                            CourseDescription = "Learn the basics of programming.",
                            CourseCode = "CS101",
                            Credits = 3,
                            HasPrerequisites = false,
                            ModifiedDate = DateTime.Now
                        },
                        new () {
                            ID = 2,
                            CourseCategoryID = 2,
                            CourseTitle = "Advanced Programming",
                            CourseDescription = "Learn advanced programming techniques.",
                            CourseCode = "CS102",
                            Credits = 4,
                            HasPrerequisites = true,
                            ModifiedDate = DateTime.Now
                        },
                        new() {
                            ID = 3,
                            CourseCategoryID = 3,
                            CourseTitle = "Web Development",
                            CourseDescription = "Learn how to build web applications.",
                            CourseCode = "CS103",
                            Credits = 3,
                            HasPrerequisites = false,
                            ModifiedDate = DateTime.Now
                        },
                        new() {
                            ID = 4,
                            CourseCategoryID = 4,
                            CourseTitle = "Database Management",
                            CourseDescription = "Learn how to manage databases.",
                            CourseCode = "CS104",
                            Credits = 3,
                            HasPrerequisites = false,
                            ModifiedDate = DateTime.Now
                        },
                        new() {
                            ID = 5,
                            CourseCategoryID = 5,
                            CourseTitle = "Data Structures",
                            CourseDescription = "Learn about data structures.",
                            CourseCode = "CS105",
                            Credits = 3,
                            HasPrerequisites = false,
                            ModifiedDate = DateTime.Now
                        },
                        new() {
                            ID = 6,
                            CourseCategoryID = 6,
                            CourseTitle = "Algorithms",
                            CourseDescription = "Learn about algorithms.",
                            CourseCode = "CS106",
                            Credits = 3,
                            HasPrerequisites = false,
                            ModifiedDate = DateTime.Now
                        },
                        new() {
                            ID = 7,
                            CourseCategoryID = 7,
                            CourseTitle = "Software Engineering",
                            CourseDescription = "Learn about software engineering.",
                            CourseCode = "CS107",
                            Credits = 3,
                            HasPrerequisites = false,
                            ModifiedDate = DateTime.Now
                        },
                        new() {
                            ID = 8,
                            CourseCategoryID = 8,
                            CourseTitle = "Computer Networks",
                            CourseDescription = "Learn about computer networks.",
                            CourseCode = "CS108",
                            Credits = 3,
                            HasPrerequisites = false,
                            ModifiedDate = DateTime.Now
                        },
                        new() {
                            ID = 9,
                            CourseCategoryID = 9,
                            CourseTitle = "Operating Systems",
                            CourseDescription = "Learn about operating systems.",
                            CourseCode = "CS109",
                            Credits = 3,
                            HasPrerequisites = false,
                            ModifiedDate = DateTime.Now
                        },
                        new() {
                            ID = 10,
                            CourseCategoryID = 10,
                            CourseTitle = "Computer Architecture",
                            CourseDescription = "Learn about computer architecture.",
                            CourseCode = "CS110",
                            Credits = 3,
                            HasPrerequisites = false,
                            ModifiedDate = DateTime.Now
                        }
                    ];
                }
                else
                {

                    var connectionString = _configuration.GetConnectionString("StudentDataHubDbConnection");
                    LoadCourses();
                    // using var connection = new SqlConnection(connectionString);
                    // {
                    //     connection.Open();
                    //     var command = new SqlCommand("SELECT * FROM [dbo].[Course]", connection);
                    //     using var reader = command.ExecuteReader();

                    //     while (reader.Read())
                    //     {
                    //         Courses.Add(new CourseModel
                    //         {
                    //             ID = int.Parse(reader["ID"].ToString()!),
                    //             CourseCategoryID = int.Parse(reader["CourseCategoryID"].ToString()!),
                    //             CourseTitle = reader["CourseTitle"].ToString()!,
                    //             CourseDescription = reader["CourseDescription"].ToString()!,
                    //             CourseCode = reader["CourseCode"].ToString()!,
                    //             Credits = int.Parse(reader["Credits"].ToString()!),
                    //             HasPrerequisites = reader.GetBoolean(6),
                    //             ModifiedDate = reader.GetDateTime(7)
                    //         });
                    //     }
                    // }
                }

            }
            catch (SqlException ex)
            {
                _logger.LogError(ex, "Error loading courses from database");
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, "An unexpected error occurred");
            }
            finally
            {
                _logger.LogInformation("Courses loaded from database");
            }
        }

        private void LoadCourses()
        {
            Courses = [
                        new() {
                            ID = 1,
                            CourseCategoryID = 1,
                            CourseTitle = "Introduction to Programming",
                            CourseDescription = "Learn the basics of programming.",
                            CourseCode = "CS101",
                            Credits = 3,
                            HasPrerequisites = false,
                            ModifiedDate = DateTime.Now
                        },
                        new () {
                            ID = 2,
                            CourseCategoryID = 2,
                            CourseTitle = "Advanced Programming",
                            CourseDescription = "Learn advanced programming techniques.",
                            CourseCode = "CS102",
                            Credits = 4,
                            HasPrerequisites = true,
                            ModifiedDate = DateTime.Now
                        },
                        new() {
                            ID = 3,
                            CourseCategoryID = 3,
                            CourseTitle = "Web Development",
                            CourseDescription = "Learn how to build web applications.",
                            CourseCode = "CS103",
                            Credits = 3,
                            HasPrerequisites = false,
                            ModifiedDate = DateTime.Now
                        },
                        new() {
                            ID = 4,
                            CourseCategoryID = 4,
                            CourseTitle = "Database Management",
                            CourseDescription = "Learn how to manage databases.",
                            CourseCode = "CS104",
                            Credits = 3,
                            HasPrerequisites = false,
                            ModifiedDate = DateTime.Now
                        },
                        new() {
                            ID = 5,
                            CourseCategoryID = 5,
                            CourseTitle = "Data Structures",
                            CourseDescription = "Learn about data structures.",
                            CourseCode = "CS105",
                            Credits = 3,
                            HasPrerequisites = false,
                            ModifiedDate = DateTime.Now
                        },
                        new() {
                            ID = 6,
                            CourseCategoryID = 6,
                            CourseTitle = "Algorithms",
                            CourseDescription = "Learn about algorithms.",
                            CourseCode = "CS106",
                            Credits = 3,
                            HasPrerequisites = false,
                            ModifiedDate = DateTime.Now
                        },
                        new() {
                            ID = 7,
                            CourseCategoryID = 7,
                            CourseTitle = "Software Engineering",
                            CourseDescription = "Learn about software engineering.",
                            CourseCode = "CS107",
                            Credits = 3,
                            HasPrerequisites = false,
                            ModifiedDate = DateTime.Now
                        },
                        new() {
                            ID = 8,
                            CourseCategoryID = 8,
                            CourseTitle = "Computer Networks",
                            CourseDescription = "Learn about computer networks.",
                            CourseCode = "CS108",
                            Credits = 3,
                            HasPrerequisites = false,
                            ModifiedDate = DateTime.Now
                        },
                        new() {
                            ID = 9,
                            CourseCategoryID = 9,
                            CourseTitle = "Operating Systems",
                            CourseDescription = "Learn about operating systems.",
                            CourseCode = "CS109",
                            Credits = 3,
                            HasPrerequisites = false,
                            ModifiedDate = DateTime.Now
                        },
                        new() {
                            ID = 10,
                            CourseCategoryID = 10,
                            CourseTitle = "Computer Architecture",
                            CourseDescription = "Learn about computer architecture.",
                            CourseCode = "CS110",
                            Credits = 3,
                            HasPrerequisites = false,
                            ModifiedDate = DateTime.Now
                        }
                    ];
        }
    }
}
