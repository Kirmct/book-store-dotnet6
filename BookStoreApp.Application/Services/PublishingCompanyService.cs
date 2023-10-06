using AutoMapper;
using BookStoreApp.Application.DTOs;
using BookStoreApp.Application.Services.Interfaces;
using BookStoreApp.Domain.Entities;
using BookStoreApp.Domain.Repositories;

namespace BookStoreApp.Application.Services
{
    public class PublishingCompanyService : IPublishingCompanyService
    {
        private readonly IPublishingCompanyRepository _publishingRepository;
        private readonly IMapper _mapper;

        public PublishingCompanyService(IPublishingCompanyRepository publishingCompanyRepository,
            IMapper mapper)
        {
            _mapper = mapper;
            _publishingRepository = publishingCompanyRepository;
        }

        public async Task<PublishingCompanyResponseDTO> Create(PublishingCompanyRequestDTO request)
        {
            var requestConverted = _mapper.Map<PublishingCompany>(request);
            var result = await _publishingRepository.Create(requestConverted);

            return _mapper.Map<PublishingCompanyResponseDTO>(result);
        }

        public async Task<ICollection<PublishingCompanyResponseDTO>> FindAll()
        {
            var response = await _publishingRepository.FindAll();

            return _mapper.Map<ICollection<PublishingCompanyResponseDTO>>(response);
        }

        public async Task<PublishingCompanyResponseDTO> FindById(int id)
        {
            var result = await _publishingRepository.FindById(id);

            return _mapper.Map<PublishingCompanyResponseDTO>(result);
        }
    }
}
