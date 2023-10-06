using BookStoreApp.Domain.Entities;

namespace BookStoreApp.Application.DTOs
{
    public class AuthorResponseDTO
    {
        public int Id { get; set; }
        public string? AuthorName { get; set; }
        public DateTime Birthday { get; set; }
        public string? Country { get; set; }
        public ICollection<BookAuthor> BookAuthors { get; set; } = new List<BookAuthor>();

        public AuthorResponseDTO()
        {}
    }
}
