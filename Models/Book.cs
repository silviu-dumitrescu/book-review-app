namespace mybookapp.Models
{
    public class Book
    {
        public int BookId { get; set; }
        public string? Title { get; set; }
        public int? AuthorId { get; set; }
        public Author? Author { get; set; }
        public int? CategoryId { get; set; }
        public Category? Category { get; set; }
        public DateTime? PublishDate { get; set; }
        public string? ImageUrl { get; set; }
        public string? Description { get; set; }
        public ICollection<UserBook>? Reviews { get; set; }
        public ICollection<CategoryBook>? Categories { get; set; }
    }
}
