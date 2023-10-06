namespace BookStoreApp.Application.DTOs
{
    public class BookRequestDTO
    {
        public string? Title { get; set; }
        public string? Description { get; set; }
        public int PublishingCompanyId { get; set; }
        public List<int> AuthorId { get; set; }
        public BookRequestDTO()
        {}
    }
}
