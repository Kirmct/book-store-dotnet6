using BookStoreApp.Domain.Entities;

namespace BookStoreApp.Application.DTOs
{
    public class BookResponseDTO
    {
        public int Id { get; set; }
        public string? Title { get; set; }
        public string? Description { get; set; }
        public PublishingCompany PublishingCompany { get; set; }
        public ICollection<BookAuthor> BookAuthors { get; set; }

        public BookResponseDTO()
        {}
    }
}
