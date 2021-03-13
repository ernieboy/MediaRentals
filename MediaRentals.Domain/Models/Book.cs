namespace MediaRentals.Domain.Models
{
    public class Book
    {
        public BookAuthor Author { get; set; }

        public Category Category { get; set; }

        public string Isbn { get; set; }
    }
}