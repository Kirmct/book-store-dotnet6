using BookStoreApp.Domain.Entities;
using System.Text.Json.Serialization;

namespace BookStoreApp.Application.DTOs
{
    public class PublishingCompanyRequestDTO
    {

        public string? Cnpj { get; set; }

        public string? SocialName { get; set; }

        public PublishingCompanyRequestDTO()
        {}
    }
}
