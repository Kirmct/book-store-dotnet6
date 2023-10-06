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
    public class CompanyController : ControllerBase
    {
        private readonly IPublishingCompanyService _companyService;

        public CompanyController(IPublishingCompanyService companyService)
        {
            _companyService = companyService;
        }

        [HttpGet]
        public async Task<ActionResult> FindAll()
        {
            var response = await _companyService.FindAll();
            return Ok(response);   
        }
      

        [HttpGet("id")]
        public async Task<ActionResult> FindById(int id)
        {
            var response = await _companyService.FindById(id);
            return Ok(response);
        }

        [HttpPost]
        public async Task<ActionResult> Create([FromBody] PublishingCompanyRequestDTO request)
        {
            var response = await _companyService.Create(request);
            return Ok(response);
        }
    }
}
