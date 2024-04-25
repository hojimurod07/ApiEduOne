namespace Domain.Entities
{
    public  class User:BaseEntity
    {
        public string FullName { get; set; } = string.Empty;
        public string Email { get; set; } = string.Empty;
        public string Phone {  get; set; } = string.Empty;
        public string Image_Url {  get; set; } = string.Empty;
        public int CourseId { get; set; }
        public Course Course { get; set; }
    }
}
