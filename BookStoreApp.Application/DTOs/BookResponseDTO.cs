namespace BookStoreApp.Application.DTOs
{
    public class BookResponseDTO
    {
        public int Id { get; set; }
        public string? Title { get; set; }
        public string? Description { get; set; }

        public BookResponseDTO()
        {}
    }
}
