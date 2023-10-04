using AutoMapper;
using BookStoreApp.Application.DTOs;
using BookStoreApp.Application.Services.Interfaces;
using BookStoreApp.Domain.Entities;
using BookStoreApp.Domain.Repositories;

namespace BookStoreApp.Application.Services
{
    public class BookService : IBookService
    {
        private readonly IBookRepository _bookRepository;
        private readonly IMapper _mapper;

        public BookService(IBookRepository bookRepository, IMapper mapper)
        {
            _bookRepository = bookRepository;
            _mapper = mapper;
        }

        public async Task<BookResponseDTO> Create(BookRequestDTO book)
        {
            var bookConvert = _mapper.Map<Book>(book);
            var result = await _bookRepository.CreateAsync(bookConvert);
            var bookResponse = _mapper.Map<BookResponseDTO>(result);
            return bookResponse;
        }

        public async Task<ICollection<BookResponseDTO>> FindAll()
        {
            var result = await _bookRepository.FindAllAsync();
            var bookResponse = _mapper.Map<ICollection<BookResponseDTO>>(result);
            return bookResponse;
        }
    }
}
