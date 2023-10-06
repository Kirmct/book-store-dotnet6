using AutoMapper;
using BookStoreApp.Application.DTOs;
using BookStoreApp.Domain.Entities;

namespace BookStoreApp.Application.Mappings
{
    public class DomainToDTOMapping : Profile
    {
        public DomainToDTOMapping()
        {
            //domains
            CreateMap<Book, BookResponseDTO>();
            CreateMap<Book, BookRequestDTO>();

            CreateMap<Author, AuthorRequestDTO>();
            CreateMap<Author, AuthorResponseDTO>();

            CreateMap<PublishingCompany, PublishingCompanyRequestDTO>();
            CreateMap<PublishingCompany, PublishingCompanyResponseDTO>();

            //dtos
            CreateMap<BookResponseDTO, Book>();
            CreateMap<BookRequestDTO, Book>();

            CreateMap<AuthorRequestDTO, Author>();
            CreateMap<AuthorResponseDTO, Author>();

            CreateMap<PublishingCompanyRequestDTO, PublishingCompany>();
            CreateMap<PublishingCompanyResponseDTO, PublishingCompany> ();

        }
    }
}
