using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using RepositoryPatternWithUOW.Core.Interfaces;
using RepositoryPatternWithUOW.Core.Models;

namespace RepositoryPatternWithUOW.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AuthorsController : ControllerBase
    {
        readonly IBaseRepository<Author> _baseRepository;

        public AuthorsController(IBaseRepository<Author> baseRepository)
        {
            _baseRepository = baseRepository;
        }
        [HttpGet]
        public IActionResult GetById()
        {
            return Ok(_baseRepository.GetById(1));
        }
    }
}
