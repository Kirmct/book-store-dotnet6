using BookStoreApp.Application.DTOs;

namespace BookStoreApp.Application.Services.Interfaces
{
    public interface IBookService
    {
        Task<ICollection<BookResponseDTO>> FindAll();
        Task<BookResponseDTO> Create(BookRequestDTO book);
        Task<BookResponseDTO> FindById(int id);
        Task<BookResponseDTO> UpdateBook(BookRequestDTO request, int id);
    }
}
