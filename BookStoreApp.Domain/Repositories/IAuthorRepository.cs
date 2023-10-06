using BookStoreApp.Domain.Entities;

namespace BookStoreApp.Domain.Repositories
{
    public interface IAuthorRepository
    {
        Task<Author> Create(Author author);
        Task<Author> FindById(int id);
        Task<ICollection<Author>> FindAll();
    }
}
