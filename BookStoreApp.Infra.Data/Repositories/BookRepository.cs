using BookStoreApp.Domain.Entities;
using BookStoreApp.Domain.Repositories;
using BookStoreApp.Infra.Data.Context;
using Microsoft.EntityFrameworkCore;

namespace BookStoreApp.Infra.Data.Repositories
{
    public class BookRepository : IBookRepository
    {

        private readonly BookContext _db;

        public BookRepository(BookContext db)
        {
            _db = db;
        }

        public Task<Book> CreateAsync(Book book)
        {
            _db.Add(book);
            _db.SaveChanges();

            return Task.FromResult(book);
        }

        public Task DeleteAsync(int id)
        {
            throw new NotImplementedException();
        }

        public async Task<ICollection<Book>> FindAllAsync()
        {
            return await _db.Books.ToListAsync();
        }

        public Task<Book> FindByIdAsync(int id)
        {
            throw new NotImplementedException();
        }

        public Task<Book> UpdateAsync(Book book)
        {
            throw new NotImplementedException();
        }
    }
}
