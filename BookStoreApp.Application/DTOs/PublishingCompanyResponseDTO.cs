
using BookStoreApp.Domain.Entities;
using System.Text.Json.Serialization;

namespace BookStoreApp.Application.DTOs
{
    public class PublishingCompanyResponseDTO
    {
        public int Id { get; set; }

        public string Cnpj { get; set; }

        public string SocialName { get; set; }
        [JsonIgnore]
        public ICollection<Book> Books { get; set; } = new List<Book>();
        public PublishingCompanyResponseDTO()
        {}
    }
}
