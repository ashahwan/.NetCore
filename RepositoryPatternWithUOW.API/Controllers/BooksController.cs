using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using RepositoryPatternWithUOW.Core.Interfaces;
using RepositoryPatternWithUOW.Core.Models;

namespace RepositoryPatternWithUOW.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class BooksController : ControllerBase
    {
        readonly IBaseRepository<Book> _baseRepository;

        public BooksController(IBaseRepository<Book> baseRepository)
        {
            _baseRepository = baseRepository;
        }
        [HttpGet]
        public IActionResult GetById()
        {
            return Ok(_baseRepository.GetById(1));
        }

        [HttpGet("GetAll")]
        public IActionResult GetAll()
        {
            return Ok(_baseRepository.GetAll());
        }

        [HttpGet("GetByName")]
        public IActionResult GetByName()
        {
            return Ok(_baseRepository.Find(b => b.Title == "New Book", new[] { "Author" }));
        }
    }
}
