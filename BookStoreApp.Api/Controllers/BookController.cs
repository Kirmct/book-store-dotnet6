using BookStoreApp.Application.DTOs;
using BookStoreApp.Application.Services.Interfaces;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace BookStoreApp.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class BookController : ControllerBase
    {
        private readonly IBookService _service;

        public BookController(IBookService service)
        {
            _service = service;
        }

        [HttpPost]
        public async Task<IActionResult> Create([FromBody] BookRequestDTO request)
        {
            var result = await _service.Create(request);
            return Ok(result);
        }

        [HttpGet]
        public async Task<ActionResult> FindAll()
        {
            return Ok(await _service.FindAll());
        }
    }
}
