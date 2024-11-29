namespace mybookapp.Models
{
    public class UserBook
    {
        public int UserBookId { get; set; }
        public int BookId { get; set; }
        public Book? Book { get; set; }
        public int UserId { get; set; }
        public User? User { get; set; }
        public bool? IsRead { get; set; }
        public int? Rating { get; set; }
        public string? Review { get; set; }
    }
}
