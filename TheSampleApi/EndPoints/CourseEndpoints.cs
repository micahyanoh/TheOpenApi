using TheSampleApi.Data;

namespace TheSampleApi.EndPoints
{
    public static class CourseEndpoints
    {
        public static void AddCourseEndpoints(this WebApplication app)
        {
           app.MapGet("/courses", (CourseData data) => {
                return Results.Ok(data.Courses);
           });
        }
    }
}
