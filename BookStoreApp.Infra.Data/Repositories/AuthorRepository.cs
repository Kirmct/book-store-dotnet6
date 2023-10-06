using BookStoreApp.Domain.Entities;
using BookStoreApp.Domain.Repositories;
using BookStoreApp.Infra.Data.Context;
using Microsoft.EntityFrameworkCore;

namespace BookStoreApp.Infra.Data.Repositories
{
    public class AuthorRepository : IAuthorRepository
    {

        private readonly BookContext _db;

        public AuthorRepository(BookContext db)
        {
            _db = db;
        }

        public async Task<Author> Create(Author author)
        {
            await _db.Authors.AddAsync(author);
            await _db.SaveChangesAsync();
            return author;
        }

        public async Task<ICollection<Author>> FindAll()
        {
            var response = await _db.Authors.Include(x => x.BookAuthors).ToListAsync();
            return response;
        }

        public async Task<Author?> FindById(int id)
        {
            var response = await _db.Authors
                .Where(a => a.Id == id).Include(b => b.BookAuthors)
                .FirstOrDefaultAsync();
            return response;
        }
    }
}
