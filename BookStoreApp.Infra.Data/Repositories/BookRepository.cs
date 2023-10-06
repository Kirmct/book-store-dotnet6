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

        public async Task<Book> CreateAsync(Book book)
        {
            _db.Add(book);
            return book;
        }

        public Task DeleteAsync(int id)
        {
            throw new NotImplementedException();
        }

        public async Task<ICollection<Book>> FindAllAsync()
        {
            return await _db.Books.Include(x => x.BookAuthors).Include(x => x.PublishingCompany).ToListAsync();
        }

        public async Task<Book> FindByIdAsync(int id)
        {
            var response = await _db.Books.Where(b => b.Id == id)
                .Include(x => x.BookAuthors)
                .Include(x => x.PublishingCompany).FirstOrDefaultAsync();
            return response;
        }

        public async Task SaveAllChanges()
        {
            await _db.SaveChangesAsync();
        }

        public async Task<Book> UpdateAsync(Book book)
        {
            _db.Entry(book).State = EntityState.Modified;
            await _db.SaveChangesAsync();
            return book;
        }
    }
}
