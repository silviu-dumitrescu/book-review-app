namespace mybookapp.Models
{
    public class Author
    {
        public int AuthorId { get; set; }
        public string? Name { get; set; }
        public string? Description { get; set; }
        public DateTime? BirthDate { get; set; }
        public ICollection<Book>? Books { get; set; }
    }
}
