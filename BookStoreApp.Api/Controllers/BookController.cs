﻿using BookStoreApp.Application.DTOs;
using BookStoreApp.Application.Services.Interfaces;
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
        public async Task<IActionResult> Create([FromBody] BookRequestDTO request)
        {
            var response = await _service.Create(request);
            return Ok(response);
        }

        [HttpPut("id")]
        public async Task<ActionResult> Update([FromBody] BookRequestDTO requestDTO, int id)
        {
            var response = await _service.UpdateBook(requestDTO, id);
            return Ok(response);
        }

    }
}
