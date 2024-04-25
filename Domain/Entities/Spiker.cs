
namespace Domain.Entities
{
    public class Spiker :BaseEntity
    {
        public string FullName { get; set; } = string.Empty;
        public string Email { get; set; } = string.Empty;
        public string ImageUrl { get; set; } = string.Empty;

        public List<Course> Courses { get; set; } = new List<Course>();
    }
}
