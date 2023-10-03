using BookStoreApp.Application.DTOs;
using BookStoreApp.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookStoreApp.Application.Services.Interfaces
{
    public interface IBookService
    {
        Task<ICollection<BookResponseDTO>> FindAll();
        Task<BookResponseDTO> Create(BookRequestDTO book);
    }
}
