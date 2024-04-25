
namespace Domain.Entities
{
    public  class Course:BaseEntity
    {
        public string Title { get; set; } = string.Empty;
        public string Description { get; set; } = string.Empty;
        public string CourseLink { get; set; } = string.Empty;
        public int CategoryId { get; set; }
        public Category Category { get; set; }
        public int SpikerId {  get; set; }
        public Spiker Spiker { get; set; }
        public List<User> Users { get; set; } = new List<User>();
    }
}
