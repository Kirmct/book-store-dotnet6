using BookStoreApp.Domain.Entities;
using BookStoreApp.Domain.Repositories;
using BookStoreApp.Infra.Data.Context;
using Microsoft.EntityFrameworkCore;

namespace BookStoreApp.Infra.Data.Repositories
{
    public class PublishingCompanyRepository : IPublishingCompanyRepository
    {
        private readonly BookContext _db;

        public PublishingCompanyRepository(BookContext db)
        {
            _db = db;
        }

        public async Task<PublishingCompany> Create(PublishingCompany company)
        {
            _db.Publishings.Add(company);
            await _db.SaveChangesAsync();

            return company;
        }

        public async Task<ICollection<PublishingCompany>> FindAll()
        {
            var response = await _db.Publishings.ToListAsync();
            return response;
        }

        public async Task<PublishingCompany> FindById(int id)
        {
            var response = await _db.Publishings.Where(p => p.Id == id).FirstOrDefaultAsync();

            return response;
        }
    }
}
