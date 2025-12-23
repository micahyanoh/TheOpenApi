using TheSampleApi.Data;

namespace TheSampleApi.EndPoints
{
    public static class CourseEndpoints
    {
        public static void AddCourseEndpoints(this WebApplication app)
        {
           app.MapGet("/courses", LoadAllCourses);
           app.MapGet("/courses/{id}", LoadCoursesById);
        }

        private static IResult LoadAllCourses(CourseData data)
        {
            return Results.Ok(data.Courses);
        }
        private static IResult LoadCoursesById(CourseData data, int id)
        {
            return Results.Ok(data.Courses.SingleOrDefault(x=>x.Id==id));
        }
    }
}
