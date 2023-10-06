using BookStoreApp.Application.DTOs;
using BookStoreApp.Application.DTOs.Validations;
using BookStoreApp.Application.Mappings;
using BookStoreApp.Application.Services;
using BookStoreApp.Application.Services.Interfaces;
using BookStoreApp.Domain.Repositories;
using BookStoreApp.Infra.Data.Context;
using BookStoreApp.Infra.Data.Repositories;
using FluentValidation;
using FluentValidation.AspNetCore;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

namespace BookStoreApp.Infra.Data.Ioc
{
    public static class DependencyInject
    {
        public static IServiceCollection AddInfrastructure(this IServiceCollection services,
            IConfiguration configuration)
        {
            services.AddDbContext<BookContext>(options =>
                options.UseNpgsql(configuration.GetConnectionString("Default"))
            );

            services.AddScoped<IBookRepository, BookRepository>();
            services.AddScoped<IAuthorRepository, AuthorRepository>();
            services.AddScoped<IPublishingCompanyRepository, PublishingCompanyRepository>();

            return services;
        }

        public static IServiceCollection AddServices(this IServiceCollection services,
            IConfiguration configuration)
        {
            services.AddAutoMapper(typeof(DomainToDTOMapping));
            

            services.AddFluentValidationAutoValidation();
            services.AddScoped<IValidator<BookRequestDTO>, BookRequestValidator>();

            services.AddScoped<IBookService, BookService>();
            services.AddScoped<IAuthorService, AuthorService>();
            services.AddScoped<IPublishingCompanyService, PublishingCompanyService>();

            return services;
        }
    }
}
