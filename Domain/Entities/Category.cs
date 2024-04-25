namespace Domain.Entities
{
    public  class Category:BaseEntity
    {
        public string Name { get; set; } = string.Empty;
        public string Description { get; set; }  = string.Empty ;
        public List<Course> Courses { get; set; } = new List<Course>();
    }
}
