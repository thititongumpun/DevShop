using System.Threading.Tasks;
using devshops.Core.Developer;
using devshops.Domain.Developer.ViewModels;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;

namespace devshops.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class DeveloperController : ControllerBase
    {
        protected readonly IDeveloperService _developerService;
        protected readonly ILogger<DeveloperController> _logger;
        public DeveloperController(IDeveloperService developerService, ILogger<DeveloperController> logger)
        {
            _developerService = developerService;
            _logger = logger;
        }

        [HttpGet]
        public async Task<ActionResult<DeveloperViewModel>> GetAllDevelopers()
        {
            var developers = await _developerService.GetAllDevelopers();
            _logger.LogInformation("Geting all developers ...");
            return Ok(developers);
        }

        [HttpGet("{id}")]
        public async Task<ActionResult<DeveloperViewModel>> GetDeveloper(int id)
        {
            var developer = await _developerService.GetDeveloper(id);
            _logger.LogInformation($"Geting developer {id}...");
            return Ok(developer);
        }
    }
}