using BookStoreApp.Domain.Entities;

namespace BookStoreApp.Domain.Repositories
{
    public interface IBookRepository
    {
        Task<ICollection<Book>> FindAllAsync();
        Task<Book> FindByIdAsync(int id);
        Task<Book> CreateAsync(Book book);
        Task<Book> UpdateAsync(Book book);
        Task DeleteAsync(int id);
    }
}
