using AutoMapper;
using BookStoreApp.Application.DTOs;
using BookStoreApp.Application.Services.Interfaces;
using BookStoreApp.Domain.Entities;
using BookStoreApp.Domain.Repositories;

namespace BookStoreApp.Application.Services
{
    public class AuthorService : IAuthorService
    {
        private readonly IAuthorRepository _authorRepository;
        private readonly IMapper _mapper;

        public AuthorService(IAuthorRepository authorRepository, IMapper mapper)
        {
            _authorRepository = authorRepository;
            _mapper = mapper;
        }

        public async Task<AuthorResponseDTO> Create(AuthorRequestDTO request)
        {
            var requestConvertida = _mapper.Map<Author>(request);
            var result = await _authorRepository.Create(requestConvertida);

            return _mapper.Map<AuthorResponseDTO>(result);
        }

        public async Task<ICollection<AuthorResponseDTO>> FindAll()
        {
            var response = await _authorRepository.FindAll();
            return _mapper.Map<ICollection<AuthorResponseDTO>>(response);
        }

        public async Task<AuthorResponseDTO> FindById(int id)
        {
            var response = await _authorRepository.FindById(id);

            return _mapper.Map<AuthorResponseDTO>(response);
        }
    }
}
