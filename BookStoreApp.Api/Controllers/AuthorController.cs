using BookStoreApp.Application.DTOs;
using BookStoreApp.Application.Services.Interfaces;
using BookStoreApp.Domain.Entities;
using BookStoreApp.Infra.Data.Context;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace BookStoreApp.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AuthorController : ControllerBase
    {

        private readonly IAuthorService _service;

        public AuthorController(IAuthorService service)
        {
            _service = service;
        }

        [HttpGet]
        public async Task<ActionResult> FindAll() 
        {
            var response = await _service.FindAll();
            return Ok(response);
        }

        [HttpGet("id")]
        public async Task<ActionResult> FindById(int id)
        {
            var response = await _service.FindById(id);
            return Ok(response);
        }

        [HttpPost]
        public async Task<ActionResult> Create([FromBody] AuthorRequestDTO request)
        {
            var response = await _service.Create(request);
            return Ok(response);
        }
    }
}
