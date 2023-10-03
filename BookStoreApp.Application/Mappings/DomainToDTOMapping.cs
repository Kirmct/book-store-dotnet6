using AutoMapper;
using BookStoreApp.Application.DTOs;
using BookStoreApp.Domain.Entities;

namespace BookStoreApp.Application.Mappings
{
    public class DomainToDTOMapping : Profile
    {
        public DomainToDTOMapping()
        {
            CreateMap<Book, BookResponseDTO>();
            CreateMap<Book, BookRequestDTO>();

            CreateMap<BookResponseDTO, Book>();
            CreateMap<BookRequestDTO, Book>();
        }
    }
}
