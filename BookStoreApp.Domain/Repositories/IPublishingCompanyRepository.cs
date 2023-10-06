using BookStoreApp.Domain.Entities;

namespace BookStoreApp.Domain.Repositories
{
    public interface IPublishingCompanyRepository
    {
        Task<PublishingCompany> Create(PublishingCompany company);
        Task<PublishingCompany> FindById(int id);
        Task<ICollection<PublishingCompany>> FindAll();
    }
}
