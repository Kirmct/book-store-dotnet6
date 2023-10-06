using AutoMapper;
using BookStoreApp.Application.DTOs;
using BookStoreApp.Application.Services.Interfaces;
using BookStoreApp.Domain.Entities;
using BookStoreApp.Domain.Repositories;
using System.Security.Cryptography.X509Certificates;

namespace BookStoreApp.Application.Services
{
    public class BookService : IBookService
    {
        private readonly IBookRepository _bookRepository;
        private readonly IAuthorRepository _authorRepository;
        private readonly IPublishingCompanyRepository _publishingCompanyRepository;
        private readonly IMapper _mapper;

        public BookService(IBookRepository bookRepository, IMapper mapper
            , IAuthorRepository authorRepository, IPublishingCompanyRepository publishingCompanyRepository)
        {
            _bookRepository = bookRepository;
            _mapper = mapper;
            _authorRepository = authorRepository;
            _publishingCompanyRepository = publishingCompanyRepository;
        }

        public async Task<BookResponseDTO> Create(BookRequestDTO book)
        {
            var author = new List<Author>();
            foreach (int x in book.AuthorId)
            {
                author.Add(await _authorRepository.FindById(x));
            }

            var company = await _publishingCompanyRepository.FindById(book.PublishingCompanyId);

            var bookConvert = _mapper.Map<Book>(book);
            bookConvert.PublishingCompany = company;


            var result = await _bookRepository.CreateAsync(bookConvert);

            foreach (Author a in author)
            {
                result.BookAuthors.Add(new BookAuthor { AuthorId = a.Id, BookId = result.Id });
            } 
           

            await _bookRepository.SaveAllChanges();

            var bookResponse = _mapper.Map<BookResponseDTO>(result);
            return bookResponse;
        }

        public async Task<ICollection<BookResponseDTO>> FindAll()
        {
            var result = await _bookRepository.FindAllAsync();
            var bookResponse = _mapper.Map<ICollection<BookResponseDTO>>(result);
            return bookResponse;
        }

        public async Task<BookResponseDTO> FindById(int id)
        {
            var response = await _bookRepository.FindByIdAsync(id);

            return _mapper.Map<BookResponseDTO>(response);
        }

        public async Task<BookResponseDTO> UpdateBook(BookRequestDTO request, int id)
        {
            var book = await _bookRepository.FindByIdAsync(id);
            
            var bookAuthors = new List<BookAuthor>();
            foreach (int a in request.AuthorId)
            {
                bookAuthors.Add(new BookAuthor { AuthorId = a, BookId = book.Id});
            }

            var company = await _publishingCompanyRepository.FindById(request.PublishingCompanyId);

            book.BookAuthors = bookAuthors;
            book.PublishingCompany = company;
            var response = await _bookRepository.UpdateAsync(book);

            return _mapper.Map<BookResponseDTO>(response);
        }
    }
}
