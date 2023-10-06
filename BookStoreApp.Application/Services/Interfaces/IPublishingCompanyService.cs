using BookStoreApp.Application.DTOs;

namespace BookStoreApp.Application.Services.Interfaces
{
    public interface IPublishingCompanyService
    {
        Task<PublishingCompanyResponseDTO> Create(PublishingCompanyRequestDTO request);
        Task<PublishingCompanyResponseDTO> FindById(int id);
        Task<ICollection<PublishingCompanyResponseDTO>> FindAll();
    }
}
