
namespace BookStoreApp.Application.DTOs
{
    public class AuthorRequestDTO
    {
        public string? AuthorName { get; set; }
        public DateTime Birthday { get; set; }
        public string? Country { get; set; }
    }
}
