namespace BookStoreApp.Domain.Entities
{
    public class Book
    {
        public int Id { get; set; }
        public string? Title { get; set; }
        public string? Description { get; set; }
        public int PublishingCompanyId { get; set; }
        public PublishingCompany? PublishingCompany { get; set; }
        public ICollection<BookAuthor> BookAuthors { get; set; } = new List<BookAuthor>();

        public Book()
        {}
    }
}
