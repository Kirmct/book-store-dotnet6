
using BookStoreApp.Application.DTOs;
using BookStoreApp.Domain.Entities;

namespace BookStoreApp.Application.Services.Interfaces
{
    public interface IAuthorService
    {
        public Task<AuthorResponseDTO> Create(AuthorRequestDTO request);
        public Task<AuthorResponseDTO> FindById(int id);
        public Task<ICollection<AuthorResponseDTO>> FindAll();
    }
}
