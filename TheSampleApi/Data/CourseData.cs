using TheSampleApi.Models;

namespace TheSampleApi.Data
{
    public class CourseData
    {
        public List<CourseModel> Courses { get; set; }
        public CourseData() 
        { 
            var options = new System.Text.Json.JsonSerializerOptions
            {
                PropertyNameCaseInsensitive = true
            };

            // string filePath = Path.Combine(AppContext.BaseDirectory, "Data", "Coursedata.json");
            string filePath = Path.Combine(Directory.GetCurrentDirectory(),
                "Data",
                "Coursedata.json");
            string json = File.ReadAllText(filePath);
            Courses = System.Text.Json.JsonSerializer.Deserialize<List<CourseModel>>(json, options) ?? new List<CourseModel>();
        }
    }
}
